'use strict';

require.config({
  baseUrl: "/Scripts/app",

  paths: {

    jquery: "/Scripts/lib/jquery-2.1.1.min",
    bootstrap: '/Scripts/lib/bootstrap.min',
    
    breeze: '/Scripts/lib/breeze.min',

    angular: '/Scripts/lib/angular.min',
    angularRoute: '/Scripts/lib/angular-route.min',
    angularMocks: '/Scripts/lib/angular-mocks',
    angularUI: '/Scripts/lib/angular-ui/ui-bootstrap-tpls',
    breezeAngular: '/Scripts/lib/breeze.angular',

  
  },
  shim: {
    jquery: {
      exports: 'jquery'
    },
    bootstrap: {
      deps: ["jquery"],
      exports: "$.fn.popover"
    },
    breeze: {
      exports: 'breeze'
    },
    /* Angular */
    angular: {
      deps: ['jquery'],
      'exports': 'angular'
    },
    angularRoute: ['angular'],
    angularMocks: {
      deps: ['angular'],
      'exports': 'angular.mock'
    },
    angularUI: ['angular', 'bootstrap'],
    breezeAngular: ['angular', 'breeze'],
  },
  priority: [
    "angular"
  ]
});

//http://code.angularjs.org/1.2.1/docs/guide/bootstrap#overview_deferred-bootstrap
window.name = "NG_DEFER_BOOTSTRAP!";

require(['angular', 'bootstrap', 'app' ,'routes'], function (angular, bootstrap, app) {
  // defer bootstrap
  var $html = angular.element(document.getElementsByTagName('html')[0]);

  angular.element().ready(function () {
    angular.resumeBootstrap([app['name']]);
  });


  return app.run([ '$rootScope',  function ($rootScope) {

      $rootScope.$on('error:unauthorized', function (event, response) {
      });
      $rootScope.$on('error:forbidden', function (event, response) {
      });
      $rootScope.$on('error:403', function (event, response) {
      });
      $rootScope.$on('success:ok', function (event, response) {
      });
    }
  ]);
});