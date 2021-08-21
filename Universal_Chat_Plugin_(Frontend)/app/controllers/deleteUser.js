app.controller("deleteUser",function($scope, $location, ajax, $routeParams){
    ajax.get(API_ROOT+"api/User/"+$routeParams.id+"/Delete",function(response){
        $scope.deleteUser = response.data;
    },
    function(error){
    });
    $scope.deleteUserr = function(){
        ajax.post(API_ROOT+"api/User/"+$routeParams.id+"/Delete",$routeParams.id,
        function(response){
            $scope.msg = "Deleted Successfully";
            $location.path("/User/All");
        },
        function(err){

        });
    };
});
