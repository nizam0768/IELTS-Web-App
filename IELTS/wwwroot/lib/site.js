window.blazorInterop = window.blazorInterop || {};

window.blazorInterop.showAlert = function (title, message, type, duration) {
    $.toast({ title, message, type, duration });
};

window.blazorInterop.applyDataTable = function (tableId) {
    setTimeout(() => {
        const table = document.getElementById(tableId);
        if (table) {
            $('#' + tableId).DataTable({
                order: [[0, 'asc']],
                scrollX: true,
                paging: true,
                info: true,
                columnDefs: [
                    { width: '15%', targets: 0 },
                    { width: '10%', targets: 1 },
                    { width: '15%', targets: 2 },
                    { width: '40%', targets: 3 },
                    { width: '20%', targets: 4 }
                ]
            });
        }
    });
};

//function InitTable() {
//    $("#example").DataTable();
//}
//window.applyDataTable = function (tableId) {
//    setTimeout(function () {
//        const table = document.getElementById(tableId);
//        if (table) {
//            console.log("Table found. Trying to initialize DataTable.");
//            $('#' + tableId).DataTable({
//                order: [[0, 'asc']],
//                scrollX: true,
//                paging: true,
//                info: true,
//                columnDefs: [
//                    { width: '15%', targets: 0 },  
//                    { width: '10%', targets: 1 }, 
//                    { width: '15%', targets: 2 }, 
//                    { width: '40%', targets: 3 },
//                    { width: '20%', targets: 4 } 
//                ]
//            });
//        } else {
//            console.warn('Table not found:', tableId);
//        }
//    });
//};