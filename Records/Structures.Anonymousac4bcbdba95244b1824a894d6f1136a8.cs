namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (28tLrFKpsUSCSolNbxE2qA)
///  <code>RC_a0ca9572f9e7d998d312de7b2a0a8fa0</code> that represent
/// s
///  <code>FolioSAPDataFolioOrderMainOrderDetailCompanySupplierFrequencyProject_Asset_ServiceBusinessVal
/// ueCategoryBusinessValueSubcategoryRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioSAPDataFolioOrderMainOrderDetailCompanySupplierFrequencyProject_Asset_ServiceBusinessValueCategoryBusinessValueSubcategoryRecord
public partial struct RC_a0ca9572f9e7d998d312de7b2a0a8fa0 : ITypedRecord<RC_a0ca9572f9e7d998d312de7b2a0a8fa0> {
internal static readonly GlobalObjectKey IdFolioSAPData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xIbSf5GGFjMBxQJ1gK5a9Q");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdFrequency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2AnG8vhYHkF1++3uYMXd3w");
internal static readonly GlobalObjectKey IdProject_Asset_Service = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*waIIG87O4_GzAGpguX_Gjg");
internal static readonly GlobalObjectKey IdBusinessValueCategory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Cy44yO4IWZ1l5arlsX1iYQ");
internal static readonly GlobalObjectKey IdBusinessValueSubcategory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Pgajh3RmSwFLNF3OIf9NhA");

public EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord ssENFolioSAPData;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_a6239c65aa61ed4530d18a92034301bbEntityRecord ssENFrequency;

public EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord ssENProject_Asset_Service;

public EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord ssENBusinessValueCategory;

public EN_f296fc330d9916f9de4aae18321e8388EntityRecord ssENBusinessValueSubcategory;


public BitArray OptimizedAttributes;

public RC_a0ca9572f9e7d998d312de7b2a0a8fa0() {
OptimizedAttributes = null;
ssENFolioSAPData = new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENFrequency = new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord();
ssENProject_Asset_Service = new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
ssENBusinessValueCategory = new EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord();
ssENBusinessValueSubcategory = new EN_f296fc330d9916f9de4aae18321e8388EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[10];
    all[0] = new BitArray(15,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(29,false);
    all[3] = new BitArray(39,false);
    all[4] = new BitArray(11,false);
    all[5] = new BitArray(28,false);
    all[6] = new BitArray(4,false);
    all[7] = new BitArray(7,false);
    all[8] = new BitArray(6,false);
    all[9] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioSAPData.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENFrequency.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENProject_Asset_Service.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENBusinessValueCategory.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENBusinessValueSubcategory.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    }else{
    ssENFolioSAPData.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssENOrderDetail.OptimizedAttributes = value[3];
    ssENCompany.OptimizedAttributes = value[4];
    ssENSupplier.OptimizedAttributes = value[5];
    ssENFrequency.OptimizedAttributes = value[6];
    ssENProject_Asset_Service.OptimizedAttributes = value[7];
    ssENBusinessValueCategory.OptimizedAttributes = value[8];
    ssENBusinessValueSubcategory.OptimizedAttributes = value[9];
    }
}
get{
    BitArray[] all = new BitArray[10];
    all[0] = ssENFolioSAPData.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = ssENOrderDetail.OptimizedAttributes;
    all[4] = ssENCompany.OptimizedAttributes;
    all[5] = ssENSupplier.OptimizedAttributes;
    all[6] = ssENFrequency.OptimizedAttributes;
    all[7] = ssENProject_Asset_Service.OptimizedAttributes;
    all[8] = ssENBusinessValueCategory.OptimizedAttributes;
    all[9] = ssENBusinessValueSubcategory.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioSAPData.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENFrequency.Read( r, ref index);
ssENProject_Asset_Service.Read( r, ref index);
ssENBusinessValueCategory.Read( r, ref index);
ssENBusinessValueSubcategory.Read( r, ref index);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(RC_a0ca9572f9e7d998d312de7b2a0a8fa0 r) {
this = r;
}


public static bool operator == (RC_a0ca9572f9e7d998d312de7b2a0a8fa0 a, RC_a0ca9572f9e7d998d312de7b2a0a8fa0 b) {
if (a.ssENFolioSAPData != b.ssENFolioSAPData) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENFrequency != b.ssENFrequency) return false;
if (a.ssENProject_Asset_Service != b.ssENProject_Asset_Service) return false;
if (a.ssENBusinessValueCategory != b.ssENBusinessValueCategory) return false;
if (a.ssENBusinessValueSubcategory != b.ssENBusinessValueSubcategory) return false;
return true;
}

public static bool operator != (RC_a0ca9572f9e7d998d312de7b2a0a8fa0 a, RC_a0ca9572f9e7d998d312de7b2a0a8fa0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a0ca9572f9e7d998d312de7b2a0a8fa0)) return false;
return (this == (RC_a0ca9572f9e7d998d312de7b2a0a8fa0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioSAPData.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENFrequency.GetHashCode()
 ^ ssENProject_Asset_Service.GetHashCode()
 ^ ssENBusinessValueCategory.GetHashCode()
 ^ ssENBusinessValueSubcategory.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioSAPData.RecursiveReset();
ssENFolio.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENFrequency.RecursiveReset();
ssENProject_Asset_Service.RecursiveReset();
ssENBusinessValueCategory.RecursiveReset();
ssENBusinessValueSubcategory.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioSAPData.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENFrequency.InternalRecursiveSave();
ssENProject_Asset_Service.InternalRecursiveSave();
ssENBusinessValueCategory.InternalRecursiveSave();
ssENBusinessValueSubcategory.InternalRecursiveSave();
}


public RC_a0ca9572f9e7d998d312de7b2a0a8fa0 Duplicate() {
RC_a0ca9572f9e7d998d312de7b2a0a8fa0 t;
t.ssENFolioSAPData = (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord)this.ssENFolioSAPData.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENFrequency = (EN_a6239c65aa61ed4530d18a92034301bbEntityRecord)this.ssENFrequency.Duplicate();
t.ssENProject_Asset_Service = (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord)this.ssENProject_Asset_Service.Duplicate();
t.ssENBusinessValueCategory = (EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord)this.ssENBusinessValueCategory.Duplicate();
t.ssENBusinessValueSubcategory = (EN_f296fc330d9916f9de4aae18321e8388EntityRecord)this.ssENBusinessValueSubcategory.Duplicate();
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "foliosapdata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioSAPData")) variable.Value = ssENFolioSAPData; else variable.Optimized = true;
variable.SetFieldName("foliosapdata");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "frequency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Frequency")) variable.Value = ssENFrequency; else variable.Optimized = true;
variable.SetFieldName("frequency");
} else if (head == "project_asset_service") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Project_Asset_Service")) variable.Value = ssENProject_Asset_Service; else variable.Optimized = true;
variable.SetFieldName("project_asset_service");
} else if (head == "businessvaluecategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueCategory")) variable.Value = ssENBusinessValueCategory; else variable.Optimized = true;
variable.SetFieldName("businessvaluecategory");
} else if (head == "businessvaluesubcategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueSubcategory")) variable.Value = ssENBusinessValueSubcategory; else variable.Optimized = true;
variable.SetFieldName("businessvaluesubcategory");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioSAPData) {
return ssENFolioSAPData;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdFrequency) {
return ssENFrequency;
}
if (key == IdProject_Asset_Service) {
return ssENProject_Asset_Service;
}
if (key == IdBusinessValueCategory) {
return ssENBusinessValueCategory;
}
if (key == IdBusinessValueSubcategory) {
return ssENBusinessValueSubcategory;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioSAPData.Key.AsGuid) {
return ssENFolioSAPData;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdFrequency.Key.AsGuid) {
return ssENFrequency;
}
if (attributeKey == IdProject_Asset_Service.Key.AsGuid) {
return ssENProject_Asset_Service;
}
if (attributeKey == IdBusinessValueCategory.Key.AsGuid) {
return ssENBusinessValueCategory;
}
if (attributeKey == IdBusinessValueSubcategory.Key.AsGuid) {
return ssENBusinessValueSubcategory;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioSAPData.FillFromOther((IRecord) other.AttributeGet(IdFolioSAPData));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENFrequency.FillFromOther((IRecord) other.AttributeGet(IdFrequency));
ssENProject_Asset_Service.FillFromOther((IRecord) other.AttributeGet(IdProject_Asset_Service));
ssENBusinessValueCategory.FillFromOther((IRecord) other.AttributeGet(IdBusinessValueCategory));
ssENBusinessValueSubcategory.FillFromOther((IRecord) other.AttributeGet(IdBusinessValueSubcategory));
}
} // RC_a0ca9572f9e7d998d312de7b2a0a8fa0
/// <summary>
/// RecordList type
///  <code>FolioSAPDataFolioOrderMainOrderDetailCompanySupplierFrequencyProject_Asset_ServiceBusinessVal
/// ueCategoryBusinessValueSubcategoryRecordList</code> that represents a record list of
///  <code>FolioSAPData, Folio, OrderMain, OrderDetail, Company, Supplier, Frequency
/// , Project_Asset_Service, BusinessValueCategory, BusinessValueSubcategory</code>
/// </summary>
public partial class RL_7da4463726b1a0efdce09801de464da8 : GenericRecordList<RC_a0ca9572f9e7d998d312de7b2a0a8fa0>, IEnumerable, IEnumerator {

protected override RC_a0ca9572f9e7d998d312de7b2a0a8fa0 GetElementDefaultValue() {
return new RC_a0ca9572f9e7d998d312de7b2a0a8fa0();
}

public T[] ToArray<T>(Func<RC_a0ca9572f9e7d998d312de7b2a0a8fa0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7da4463726b1a0efdce09801de464da8 recordList, Func<RC_a0ca9572f9e7d998d312de7b2a0a8fa0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7da4463726b1a0efdce09801de464da8(RC_a0ca9572f9e7d998d312de7b2a0a8fa0[] array) {
  RL_7da4463726b1a0efdce09801de464da8 result = new RL_7da4463726b1a0efdce09801de464da8();
result.InnerFromArray(array);
    return result;
}

public static RL_7da4463726b1a0efdce09801de464da8 ToList<T>(T[] array, Func <T, RC_a0ca9572f9e7d998d312de7b2a0a8fa0> converter) {
  RL_7da4463726b1a0efdce09801de464da8 result = new RL_7da4463726b1a0efdce09801de464da8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7da4463726b1a0efdce09801de464da8 FromRestList<T>(RestList<T> restList, Func <T, RC_a0ca9572f9e7d998d312de7b2a0a8fa0> converter) {
  RL_7da4463726b1a0efdce09801de464da8 result = new RL_7da4463726b1a0efdce09801de464da8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7da4463726b1a0efdce09801de464da8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[10];
def[0] = new BitArray(15,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(29,false);
def[3] = new BitArray(39,false);
def[4] = new BitArray(11,false);
def[5] = new BitArray(28,false);
def[6] = new BitArray(4,false);
def[7] = new BitArray(7,false);
def[8] = new BitArray(6,false);
def[9] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a0ca9572f9e7d998d312de7b2a0a8fa0> NewList() {
return new RL_7da4463726b1a0efdce09801de464da8();
}


} // RL_7da4463726b1a0efdce09801de464da8
}

