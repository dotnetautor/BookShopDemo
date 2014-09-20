'use strict';

define(['angular', 'services'], function(angular, services) {

  /* Directives */

  angular.module('bookShop.directives', ['bookShop.services'])
    .directive('appVersion', ['version', 'logger', function(version, log) {
        return function(scope, elm, attrs) {
          log.error(version);
          elm.text(version);
        };
      }
    ])
    .directive('textbox', function() {
      return {
        scope: {
          name: '@',
          title: '@',
          thisval: '='
        },
        restrict: 'EAC',
        replace: true,
        template: '<div class="form-group"><label for="tb{{name}}">{{title}}</label><input type="text" class="form-control" id="tb{{name}}" name="{{name}}" ng-model="thisval" /></div>',
        link: function(scope, element, attr, ngModel) {
          scope.tile = scope.title || scope.name;
        }
      }
    });


});