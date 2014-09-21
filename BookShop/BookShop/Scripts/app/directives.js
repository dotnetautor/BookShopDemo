'use strict';

define(['angular', 'services', 'wysiHtml5'], function (angular, services) {

  /* Directives */

  angular.module('bookShop.directives', ['bookShop.services'])
    .directive('appVersion', ['version', 'logger', function (version, log) {
      return function (scope, elm, attrs) {
        log.error(version);
        elm.text(version);
      };
    }
    ])
    .directive('textbox', function () {
      return {
        scope: {
          name: '@',
          title: '@',
          thisval: '='
        },
        restrict: 'EAC',
        replace: true,
        template: '<div class="form-group"><label for="tb{{name}}">{{title}}</label><input type="text" class="form-control" id="tb{{name}}" name="{{name}}" ng-model="thisval" /></div>',
        link: function (scope, element, attr, ngModel) {
          scope.tile = scope.title || scope.name;
        }
      }
    })
    .directive('richTextEditor', function ($log, $location) {
      var directive = {
        restrict: "A",
        replace: true,
        transclude: true,
        require: '?ngModel',
        template: '<div><textarea style="height:300px;width:100%"></textarea></div>',
        link: function(scope, element, attrs, controller) {
          var textarea = element.find('textarea').wysihtml5({
            stylesheets: null
          });

          var editor = textarea.data('wysihtml5').editor;
          editor.on('change', function () {
            controller.$setViewValue(editor.getValue());
          });

          scope.$watch(attrs.ngModel, function(newValue, oldValue) {
            textarea.html(newValue);
            editor.setValue(newValue);
          });
        }
      }
      return directive;
    });

});