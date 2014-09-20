'use strict';
define('services', ['angular','breezeAngular'], function(angular) {
  return angular.module('bookShop.services', ['breeze.angular'])
    .value('version', '0.1 beta')
   .factory('datacontext', function (breeze) {

     breeze.NamingConvention.camelCase.setAsDefault();

     var serviceName = "/breeze/BookShop/";

     var manager = new breeze.EntityManager(serviceName);


     return {
       getBooks: function (skip, take, orderBy, reverse) {
         var query = breeze.EntityQuery.from("Books");
         if (orderBy) {
           query = (reverse || false) ? query.orderByDesc(orderBy) : query.orderBy(orderBy);
         }
         if (skip || take) {
           query = query.skip(skip || 0).take(take || 10).inlineCount();
         }
         return manager.executeQuery(query);
       },

       getReaders: function (skip, take, orderBy, reverse) {
         var query = breeze.EntityQuery.from("Readers");
         if (orderBy) {
           query = (reverse || false) ? query.orderByDesc(orderBy) : query.orderBy(orderBy);
         }
         if (skip || take) {
           query = query.skip(skip || 0).take(take || 10).inlineCount();
         }
         return manager.executeQuery(query);
       },

       getBookById: function (id) {
         return manager.getEntityByKey('Book', id);
       },

       getReaderById: function (id) {
         return manager.getEntityByKey('Reader', id);
       },
     };

   });

});