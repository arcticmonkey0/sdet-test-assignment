import { DataTable } from "@cucumber/cucumber"

export class DataTableExtensions {

    public static ConvertOneColumnTableToSingleArray(table: DataTable) {
        return table.rows().join().split(",");
    }
}