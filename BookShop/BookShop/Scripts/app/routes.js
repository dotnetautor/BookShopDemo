'use strict';

define(['angular', 'app'], function(angular, app) {

  //var authResolver = {
  //  auth: [
  //    "$q", "authenticationSvc", function($q, authenticationSvc) {
  //      var userInfo = authenticationSvc.getUserInfo();

  //      if (userInfo) {
  //        return $q.when(userInfo);
  //      } else {
  //        return $q.reject({ authenticated: false });
  //      }
  //    }
  //  ]
  //};

  return app.config([
    '$routeProvider', function($routeProvider) {
      $routeProvider.when('/books', {
        templateUrl: '/home/booksView',
        controller: 'booksCtrl',
       // resolve: authResolver
      });
      $routeProvider.when('/readers', {
        templateUrl: '/home/readersView',
        controller: 'readersCtrl',
        // resolve: authResolver
      });
      $routeProvider.when('/reader/:id', {
        templateUrl: '/home/readerEdit',
        controller: 'readerEditCtrl',
        // resolve: authResolver
      });
      $routeProvider.when('/book/:id', {
        templateUrl: '/home/bookEdit',
        controller: 'bookEditCtrl',
        // resolve: authResolver
      });
      $routeProvider.when('/', {
        templateUrl: '/home/dashboard',
        //controller: 'DashboardCtrl',
        // resolve: authResolver
      });
      $routeProvider.otherwise({ redirectTo: '/' });
    }
  ]);

});
