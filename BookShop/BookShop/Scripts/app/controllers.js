'use strict';
define('controllers', ['angular'], function(angular) {
  return angular.module('bookShop.controllers', [])
     .controller("booksCtrl", [
      "$scope", "$http", "$timeout", "$location", "datacontext", function ($scope, $http, $timeout, loc, dc) {
        $scope.books = [], $scope.currentPage = 1, $scope.itemsPerPage = 10, $scope.totalItems = 0, $scope.maxSize = 5;

        $scope.$watch('currentPage + numPerPage', function () {
          updateBooks();
        });


        $scope.editBook = function (id) {
          loc.path('/book/' + id);
        };

        $scope.editReader = function (id) {
          loc.path('/reader/' + id);
        };
        function updateBooks() {
          dc.getBooks(($scope.currentPage - 1) * $scope.itemsPerPage, $scope.itemsPerPage, "id", false).then(function (data) {
            $timeout(function () {
              $scope.books = data.results;
              $scope.totalItems = data.inlineCount || 0;
            });
          });
        };

        updateBooks();



      }
     ])
    .controller('readersCtrl', [
      '$scope', function($scope) {

      }
    ]);

});