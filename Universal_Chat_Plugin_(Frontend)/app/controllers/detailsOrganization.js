app.controller("detailsOrganization",function($scope, $http, ajax, $routeParams){
    ajax.get(API_ROOT+"api/Organization/"+$routeParams.id+"/Details",function(response){
        $scope.detailsOrganization = response.data;
    },
    function(error){
    });
});