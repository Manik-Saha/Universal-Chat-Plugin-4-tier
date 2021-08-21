app.controller("detailsAdmin",function($scope, $http, ajax, $routeParams){
    ajax.get(API_ROOT+"api/Admin/"+$routeParams.id+"/Details",function(response){
        $scope.detailsAdmin = response.data;
    },
    function(error){
    });
});