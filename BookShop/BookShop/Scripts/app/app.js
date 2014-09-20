'use strict';

define('app', ['angular','controllers','services','directives','angularRoute','angularUI'], function(angular, controllers) {

    return angular.module('bookShop', ['ngRoute','bookShop.controllers','bookShop.services','bookShop.directives','ui.bootstrap']);
  }
);