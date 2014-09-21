'use strict';
define('controllers', ['angular'], function(angular) {
  return angular.module('bookShop.controllers', [])
    .controller("booksCtrl", [
      "$scope", "$http", "$timeout", "$location", "datacontext", function($scope, $http, $timeout, loc, dc) {
        $scope.books = [], $scope.currentPage = 1, $scope.itemsPerPage = 10, $scope.totalItems = 0, $scope.maxSize = 5;

        $scope.$watch('currentPage + numPerPage', function() {
          updateBooks();
        });


        $scope.editBook = function(id) {
          loc.path('/book/' + id);
        };

        $scope.editReader = function(id) {
          loc.path('/reader/' + id);
        };

        function updateBooks() {
          dc.getBooks(($scope.currentPage - 1) * $scope.itemsPerPage, $scope.itemsPerPage, "id", false).then(function(data) {
            $timeout(function() {
              $scope.books = data.results;
              $scope.totalItems = data.inlineCount || 0;
            });
          });
        };

        updateBooks();

      }
    ])
    .controller("bookEditCtrl", ["$scope", '$routeParams', "datacontext", "common", function($scope, params, dc, common) {

        // subscribe
        var hasChanges = false;
        $scope.$on("hasChangesChanged", function (event, data) {
          common.$timeout(function() {
            hasChanges = data.hasChanges;
          }, 10);
        });

        $scope.book = dc.getBookById(+params.id);

        // commands
        $scope.saveCommand = new common.AsyncCommand(save, canSave);
        $scope.cancelCommand = new common.Command(cancel, canChancel);
        $scope.backCommand = new common.Command(back, canBack);
        
        // helper functions for commands
        function save(callback) {
          dc.save().then(function(saveResult) {
            callback();
          }, function(error) {
            callback();
          });
        }

        function canSave(isExecuting) {
          return !isExecuting && hasChanges;
        }

        function cancel() {
          dc.cancel();
        }

        function canChancel() {
          return hasChanges;
        }

        function back() {
          // preventing "10 $digest() iterations reached. Aborting!"
          common.$timeout(function () {
            common.$window.history.back();
          }, 100);
        }

        function canBack() {
          return !hasChanges;
        }

      }
    ])
    .controller('readersCtrl', [
      '$scope', function($scope) {

      }
    ]);

});