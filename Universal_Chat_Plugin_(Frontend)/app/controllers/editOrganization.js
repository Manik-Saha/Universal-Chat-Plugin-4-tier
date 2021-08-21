app.controller("editOrganization",function($scope, $http, ajax, $routeParams){
    ajax.get(API_ROOT+"api/Organization/"+$routeParams.id+"/Edit",function(response){
        console.log(response.data);
        $scope.editOrganization = response.data;
    },
    function(error){
    });

    $scope.saveOrganization = function(o){
        ajax.post(API_ROOT+"api/Organization/"+$routeParams.id+"/Edit",o,
        function(response){
            $location.path("/Organization/All");
        },
        function(err){

        });
    };
});