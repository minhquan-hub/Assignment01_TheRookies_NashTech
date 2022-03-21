import { 
    VegetableType,
    FruitsType,
    JuiceType,
    DriesType,
    AllProductType,
    VegetableTypeLabel,
    FruitsTypeLabel,
    JuiceTypeLabel,
    DriesTypeLabel,
    AllProductTypeLabel
} from "../Constants/Product/ProductConstant";

export const ProductTypeOption = [
    {id: 1, label: VegetableTypeLabel, value:VegetableType},
    {id: 2, label: FruitsTypeLabel, value:FruitsType},
    {id: 3, label: JuiceTypeLabel, value:JuiceType},
    {id: 4, label: DriesTypeLabel, value:DriesType}
];

export const FilterProductTypeOptions = [
    {id: 1, label: AllProductTypeLabel, value: AllProductType},
    {id: 2, label: VegetableTypeLabel, value:VegetableType},
    {id: 3, label: FruitsTypeLabel, value:FruitsType},
    {id: 4, label: JuiceTypeLabel, value:JuiceType},
    {id: 5, label: DriesTypeLabel, value:DriesType}
]