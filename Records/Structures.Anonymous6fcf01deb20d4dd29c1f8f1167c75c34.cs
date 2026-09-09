namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (3gHPbw2y0k2cH48RZ8dcNA)
///  <code>RC_9387247c408750aafc8750d323f6a93d</code> that represent
/// s
///  <code>CurrencyUser_CreatedByUser_UpdatedByFolioStatusFolioApprovalFolioFolioApprovalLevelOrderMainC
/// ompanySupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyUser_CreatedByUser_UpdatedByFolioStatusFolioApprovalFolioFolioApprovalLevelOrderMainCompanySupplierRegionRecord
public partial struct RC_9387247c408750aafc8750d323f6a93d : ITypedRecord<RC_9387247c408750aafc8750d323f6a93d> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdUser_CreatedBy = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Oz+YqADw5Hde7dfemVySZA");
internal static readonly GlobalObjectKey IdUser_UpdatedBy = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WZNnUKKhENodXZxz_YXBVg");
internal static readonly GlobalObjectKey IdFolioStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*svddx8bnSuc6Rd2nvXuT4g");
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public ENUserEntityRecord ssENUser_CreatedBy;

public ENUserEntityRecord ssENUser_UpdatedBy;

public EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord ssENFolioStatus;

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_9387247c408750aafc8750d323f6a93d() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENUser_CreatedBy = new ENUserEntityRecord();
ssENUser_UpdatedBy = new ENUserEntityRecord();
ssENFolioStatus = new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[11];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(5,false);
    all[3] = new BitArray(6,false);
    all[4] = new BitArray(10,false);
    all[5] = new BitArray(20,false);
    all[6] = new BitArray(20,false);
    all[7] = new BitArray(29,false);
    all[8] = new BitArray(11,false);
    all[9] = new BitArray(28,false);
    all[10] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_CreatedBy.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUser_UpdatedBy.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFolioStatus.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[10];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENUser_CreatedBy.OptimizedAttributes = value[1];
    ssENUser_UpdatedBy.OptimizedAttributes = value[2];
    ssENFolioStatus.OptimizedAttributes = value[3];
    ssENFolioApproval.OptimizedAttributes = value[4];
    ssENFolio.OptimizedAttributes = value[5];
    ssENFolioApprovalLevel.OptimizedAttributes = value[6];
    ssENOrderMain.OptimizedAttributes = value[7];
    ssENCompany.OptimizedAttributes = value[8];
    ssENSupplier.OptimizedAttributes = value[9];
    ssENRegion.OptimizedAttributes = value[10];
    }
}
get{
    BitArray[] all = new BitArray[11];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENUser_CreatedBy.OptimizedAttributes;
    all[2] = ssENUser_UpdatedBy.OptimizedAttributes;
    all[3] = ssENFolioStatus.OptimizedAttributes;
    all[4] = ssENFolioApproval.OptimizedAttributes;
    all[5] = ssENFolio.OptimizedAttributes;
    all[6] = ssENFolioApprovalLevel.OptimizedAttributes;
    all[7] = ssENOrderMain.OptimizedAttributes;
    all[8] = ssENCompany.OptimizedAttributes;
    all[9] = ssENSupplier.OptimizedAttributes;
    all[10] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssENUser_CreatedBy.Read( r, ref index);
ssENUser_UpdatedBy.Read( r, ref index);
ssENFolioStatus.Read( r, ref index);
ssENFolioApproval.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENFolioApprovalLevel.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_9387247c408750aafc8750d323f6a93d r) {
this = r;
}


public static bool operator == (RC_9387247c408750aafc8750d323f6a93d a, RC_9387247c408750aafc8750d323f6a93d b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENUser_CreatedBy != b.ssENUser_CreatedBy) return false;
if (a.ssENUser_UpdatedBy != b.ssENUser_UpdatedBy) return false;
if (a.ssENFolioStatus != b.ssENFolioStatus) return false;
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_9387247c408750aafc8750d323f6a93d a, RC_9387247c408750aafc8750d323f6a93d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9387247c408750aafc8750d323f6a93d)) return false;
return (this == (RC_9387247c408750aafc8750d323f6a93d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENUser_CreatedBy.GetHashCode()
 ^ ssENUser_UpdatedBy.GetHashCode()
 ^ ssENFolioStatus.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENUser_CreatedBy.RecursiveReset();
ssENUser_UpdatedBy.RecursiveReset();
ssENFolioStatus.RecursiveReset();
ssENFolioApproval.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENUser_CreatedBy.InternalRecursiveSave();
ssENUser_UpdatedBy.InternalRecursiveSave();
ssENFolioStatus.InternalRecursiveSave();
ssENFolioApproval.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_9387247c408750aafc8750d323f6a93d Duplicate() {
RC_9387247c408750aafc8750d323f6a93d t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENUser_CreatedBy = (ENUserEntityRecord)this.ssENUser_CreatedBy.Duplicate();
t.ssENUser_UpdatedBy = (ENUserEntityRecord)this.ssENUser_UpdatedBy.Duplicate();
t.ssENFolioStatus = (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord)this.ssENFolioStatus.Duplicate();
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "user_createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_CreatedBy")) variable.Value = ssENUser_CreatedBy; else variable.Optimized = true;
variable.SetFieldName("user_createdby");
} else if (head == "user_updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_UpdatedBy")) variable.Value = ssENUser_UpdatedBy; else variable.Optimized = true;
variable.SetFieldName("user_updatedby");
} else if (head == "foliostatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioStatus")) variable.Value = ssENFolioStatus; else variable.Optimized = true;
variable.SetFieldName("foliostatus");
} else if (head == "folioapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApproval")) variable.Value = ssENFolioApproval; else variable.Optimized = true;
variable.SetFieldName("folioapproval");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "folioapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevel")) variable.Value = ssENFolioApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("folioapprovallevel");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdUser_CreatedBy) {
return ssENUser_CreatedBy;
}
if (key == IdUser_UpdatedBy) {
return ssENUser_UpdatedBy;
}
if (key == IdFolioStatus) {
return ssENFolioStatus;
}
if (key == IdFolioApproval) {
return ssENFolioApproval;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdFolioApprovalLevel) {
return ssENFolioApprovalLevel;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdUser_CreatedBy.Key.AsGuid) {
return ssENUser_CreatedBy;
}
if (attributeKey == IdUser_UpdatedBy.Key.AsGuid) {
return ssENUser_UpdatedBy;
}
if (attributeKey == IdFolioStatus.Key.AsGuid) {
return ssENFolioStatus;
}
if (attributeKey == IdFolioApproval.Key.AsGuid) {
return ssENFolioApproval;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdFolioApprovalLevel.Key.AsGuid) {
return ssENFolioApprovalLevel;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENUser_CreatedBy.FillFromOther((IRecord) other.AttributeGet(IdUser_CreatedBy));
ssENUser_UpdatedBy.FillFromOther((IRecord) other.AttributeGet(IdUser_UpdatedBy));
ssENFolioStatus.FillFromOther((IRecord) other.AttributeGet(IdFolioStatus));
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_9387247c408750aafc8750d323f6a93d
/// <summary>
/// RecordList type
///  <code>CurrencyUser_CreatedByUser_UpdatedByFolioStatusFolioApprovalFolioFolioApprovalLevelOrderMainC
/// ompanySupplierRegionRecordList</code> that represents a record list of <code>Currency, User, User,
///  FolioStatus, FolioApproval, Folio, FolioApprovalLevel, OrderMain, Company, Supplier, Region</code>
/// </summary>
public partial class RL_d6c492838bba25b2d8eac44d00689146 : GenericRecordList<RC_9387247c408750aafc8750d323f6a93d>, IEnumerable, IEnumerator {

protected override RC_9387247c408750aafc8750d323f6a93d GetElementDefaultValue() {
return new RC_9387247c408750aafc8750d323f6a93d();
}

public T[] ToArray<T>(Func<RC_9387247c408750aafc8750d323f6a93d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d6c492838bba25b2d8eac44d00689146 recordList, Func<RC_9387247c408750aafc8750d323f6a93d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d6c492838bba25b2d8eac44d00689146(RC_9387247c408750aafc8750d323f6a93d[] array) {
  RL_d6c492838bba25b2d8eac44d00689146 result = new RL_d6c492838bba25b2d8eac44d00689146();
result.InnerFromArray(array);
    return result;
}

public static RL_d6c492838bba25b2d8eac44d00689146 ToList<T>(T[] array, Func <T, RC_9387247c408750aafc8750d323f6a93d> converter) {
  RL_d6c492838bba25b2d8eac44d00689146 result = new RL_d6c492838bba25b2d8eac44d00689146();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d6c492838bba25b2d8eac44d00689146 FromRestList<T>(RestList<T> restList, Func <T, RC_9387247c408750aafc8750d323f6a93d> converter) {
  RL_d6c492838bba25b2d8eac44d00689146 result = new RL_d6c492838bba25b2d8eac44d00689146();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d6c492838bba25b2d8eac44d00689146() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[11];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(5,false);
def[3] = new BitArray(6,false);
def[4] = new BitArray(10,false);
def[5] = new BitArray(20,false);
def[6] = new BitArray(20,false);
def[7] = new BitArray(29,false);
def[8] = new BitArray(11,false);
def[9] = new BitArray(28,false);
def[10] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9387247c408750aafc8750d323f6a93d> NewList() {
return new RL_d6c492838bba25b2d8eac44d00689146();
}


} // RL_d6c492838bba25b2d8eac44d00689146
}

