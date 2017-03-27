'use strict';

app.controller('MomController', function($scope, familiData){
    $scope.Moms = familiData.Moms;
    //$scope.pattern = '\\pattern+';
});