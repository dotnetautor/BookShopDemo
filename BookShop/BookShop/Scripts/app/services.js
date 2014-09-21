'use strict';
define('services', ['angular', 'breezeAngular'], function(angular) {
  return angular.module('bookShop.services', ['breeze.angular'])
    .value('version', '0.1 beta')
    .factory('common', [
      '$rootScope', '$timeout', '$q', '$window', function($rootScope, $timeout, $q, $window) {

        var trueFunc = function() {
          return true;
        };

        function Command(execute, canExecute) {
          this.execute = function(arg1, arg2) {
            if (!this.canExecute()) return;
            return execute.apply(this, [arg1, arg2]);
          };

          this.canExecute = canExecute || trueFunc;
        }

        function AsyncCommand(execute, canExecute) {
          var self = function() {
            return self.execute.apply(this, arguments);
          };

          var isExecuting = false;
          var completeCallback = function() {
            $timeout(function() {
              isExecuting = false;
            });
          }

          self.canExecute = canExecute ? (function () { return canExecute(isExecuting); }) : (function () { return !isExecuting; });

          self.execute = function(arg1, arg2) {
            // Needed for anchors since they don't support the disabled state
            if (!self.canExecute) return

            var args = []; // Allow for these arguments to be passed on to execute delegate
            if (execute.length >= 2) {
              args.push(arg1);
            }
            if (execute.length >= 3) {
              args.push(arg2);
            }

            args.push(completeCallback);
            isExecuting = true;
            return execute.apply(this, args);
          };

          return self;
        }

        function broadcast() {
          return $rootScope.$broadcast.apply($rootScope, arguments);
        }

        return {
          Command: Command,
          AsyncCommand: AsyncCommand,
          $broadcast: broadcast,
          $timeout: $timeout,
          $q: $q,
          $window: $window
        }
      }
    ])
    .factory('datacontext', ['breeze','common', function(breeze, common) {

      breeze.NamingConvention.camelCase.setAsDefault();

      var serviceName = "/breeze/BookShop/";

      var manager = new breeze.EntityManager(serviceName);

      // attach change handler
      manager.hasChangesChanged.subscribe(function(eventArgs) {
        var data = { hasChanges: eventArgs.hasChanges };
        common.$broadcast('hasChangesChanged', data);
      });

      return {
        getBooks: function(skip, take, orderBy, reverse) {
          var query = breeze.EntityQuery.from("Books");
          if (orderBy) {
            query = (reverse || false) ? query.orderByDesc(orderBy) : query.orderBy(orderBy);
          }
          if (skip || take) {
            query = query.skip(skip || 0).take(take || 10).inlineCount();
          }
          return manager.executeQuery(query);
        },

        getReaders: function(skip, take, orderBy, reverse) {
          var query = breeze.EntityQuery.from("Readers");
          if (orderBy) {
            query = (reverse || false) ? query.orderByDesc(orderBy) : query.orderBy(orderBy);
          }
          if (skip || take) {
            query = query.skip(skip || 0).take(take || 10).inlineCount();
          }
          return manager.executeQuery(query);
        },

        getBookById: function(id) {
          return manager.getEntityByKey('Book', id);
        },

        getReaderById: function(id) {
          return manager.getEntityByKey('Reader', id);
        },

        save: function() {
          return manager.saveChanges();
        },

        cancel: function() {
          manager.rejectChanges();
        }
      };

    }]);

});