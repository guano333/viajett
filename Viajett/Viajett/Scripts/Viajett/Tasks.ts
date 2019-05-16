namespace viajett {
    export class Tasks {
        loadTasks() {
            $.ajax({
                url: '/Home/Tasks',
                type: 'GET',
                success: (result) => {
                    $("#taskcontent").html(result);
                }
            });
        }
    }
}

