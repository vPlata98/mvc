// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let App = {
    Core: {},
    Data: {},
    Page: {
        Customers: {
            List: {
                OnLoad: function() {
                    $("#clientes").DataTable({
                        "language": {
                            "url": "//cdn.datatables.net/plug-ins/1.10.19/i18n/Spanish.json"
                        }
                    });
                }
            }
        },
        Orders: {
            List: {
                OnLoad: function() {
                    $("#pedidos").DataTable({
                        "language": {
                            "url": "//cdn.datatables.net/plug-ins/1.10.19/i18n/Spanish.json"
                        }
                    });
                }
            },
            Detail: {
                OnBegin: function() { console.log("OnBegin !!!"); },
                OnSuccess: function() {
                    $(".modal-title").html("Detalle de pedido");
                    $("#b1").html("Cerrar");
                    $("#b2").hide();
                    $(".modal").show();j7

                },
                OnFailure: function() { console.log("OnFailure !!!"); },
                OnComplete: function() { console.log("OnComplete !!!"); },
            }
        }
    }
}

