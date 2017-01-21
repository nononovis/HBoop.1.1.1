(function () {
    'use strict';

    angular
        .module('zasta-app')
        .controller('productCtrl', productCtrl);

    productCtrl.$inject = ['$scope']; 

    function productCtrl($scope) {
        $scope.menu = {name:'TESSSSSSS'};

        activate();

        function activate() { }
    }
})();
