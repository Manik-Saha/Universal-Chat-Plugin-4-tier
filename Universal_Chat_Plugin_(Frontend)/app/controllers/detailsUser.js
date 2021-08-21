app.controller("detailsUser",function($scope, $http, ajax, $routeParams){
    ajax.get(API_ROOT+"api/User/"+$routeParams.id+"/Details",function(response){
        $scope.detailsUser = response.data;
    },
    function(error){
    });
});