app.controller("deleteAdmin",function($scope, $location, ajax, $routeParams){
    ajax.get(API_ROOT+"api/Admin/"+$routeParams.id+"/Delete",function(response){
        $scope.deleteAdmin = response.data;
    },
    function(error){
    });
    $scope.deleteAdminn = function(){
        ajax.post(API_ROOT+"api/Admin/"+$routeParams.id+"/Delete",$routeParams.id,
        function(response){
            $scope.msg = "Deleted Successfully";
            $location.path("/Admin/All");
        },
        function(err){

        });
    };
});
