app.controller("deleteOrganization",function($scope, $location, ajax, $routeParams){
    ajax.get(API_ROOT+"api/Organization/"+$routeParams.id+"/Delete",function(response){
        $scope.deleteOrganization = response.data;
    },
    function(error){
    });

    $scope.deleteOrganizationn = function(){
        ajax.post(API_ROOT+"api/Organization/"+$routeParams.id+"/Delete",$routeParams.id,
        function(response){
            $scope.msg = "Deleted Successfully";
            $location.path("/Organization/All");
        },
        function(err){

        });
    };
});
