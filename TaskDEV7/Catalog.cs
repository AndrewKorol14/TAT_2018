using System.Collections.Generic;

namespace TaskDEV7
{
    /// <summary>
    /// Create receiver of commands for catalog
    /// </summary>
    class Catalog
    {
        CarChooser chooser = new CarChooser("C:\\Users\\Король Андрей\\Documents\\GitHub\\TAT_2018\\TaskDEV7\\CatalogAuto.json");
        JsonEditor catalogReader = new JsonEditor();
        List<Car> catalogPossibleCars = new List<Car>();

        public List<Car> PossibleCarsInCatalog
        {
            get { return catalogPossibleCars; }
        }

        /// <summary>
        /// Output possible equipments of cars from catalog
        /// </summary>
        /// <param name="inputtedCarsFeatures">Entered car features</param>
        /// <returns>List of possible cars from catalog</returns>
        public List<Car> OutputCarsInCatalog(List<string> inputtedCarsFeatures)
        {
            catalogPossibleCars = chooser.FindPossibleEquipments(chooser.CarCatalog, inputtedCarsFeatures);
            chooser.OutputPossibleEquipments(catalogPossibleCars);
            return catalogPossibleCars;
        }
    }
}