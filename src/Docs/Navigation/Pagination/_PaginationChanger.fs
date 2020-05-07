module Navigation.Pagination.PaginationChanger
open Fable.AntD


let onShowSizeChange current (size:int) =
  console.log(current,size)


let view () =

  Pagination.pagination [
    Pagination.ShowSizeChanger true
    Pagination.OnShowSizeChange onShowSizeChange
    Pagination.DefaultCurrent 3
    Pagination.Total 500 ] []
