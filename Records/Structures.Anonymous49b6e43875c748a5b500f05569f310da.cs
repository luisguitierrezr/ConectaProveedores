namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (OOS2Scd1pUi1APBVafMQ2g)
///  <code>RC_def4a4b06f199364b3c4464c2355286a</code> that represent
/// s
///  <code>CurrencyUserFolioStatusFolioOrderMainSupplierUserCompanyApprovalProcessTypeSupplierRecord</co
/// de> <p>Description: </p>
/// </summary>
// Name: CurrencyUserFolioStatusFolioOrderMainSupplierUserCompanyApprovalProcessTypeSupplierRecord
public partial struct RC_def4a4b06f199364b3c4464c2355286a : ITypedRecord<RC_def4a4b06f199364b3c4464c2355286a> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdFolioStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*svddx8bnSuc6Rd2nvXuT4g");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdSupplierUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7OnmMx8g4GXre9XSUReN7w");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdApprovalProcessType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3A7bZn7_sKmqJY4zWt0czA");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public ENUserEntityRecord ssENUser;

public EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord ssENFolioStatus;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_360367a38fba8439556dd1e5826e0428EntityRecord ssENSupplierUser;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord ssENApprovalProcessType;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_def4a4b06f199364b3c4464c2355286a() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENUser = new ENUserEntityRecord();
ssENFolioStatus = new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENSupplierUser = new EN_360367a38fba8439556dd1e5826e0428EntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENApprovalProcessType = new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[9];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(6,false);
    all[3] = new BitArray(20,false);
    all[4] = new BitArray(29,false);
    all[5] = new BitArray(15,false);
    all[6] = new BitArray(11,false);
    all[7] = new BitArray(5,false);
    all[8] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENSupplierUser.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENApprovalProcessType.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENUser.OptimizedAttributes = value[1];
    ssENFolioStatus.OptimizedAttributes = value[2];
    ssENFolio.OptimizedAttributes = value[3];
    ssENOrderMain.OptimizedAttributes = value[4];
    ssENSupplierUser.OptimizedAttributes = value[5];
    ssENCompany.OptimizedAttributes = value[6];
    ssENApprovalProcessType.OptimizedAttributes = value[7];
    ssENSupplier.OptimizedAttributes = value[8];
    }
}
get{
    BitArray[] all = new BitArray[9];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENUser.OptimizedAttributes;
    all[2] = ssENFolioStatus.OptimizedAttributes;
    all[3] = ssENFolio.OptimizedAttributes;
    all[4] = ssENOrderMain.OptimizedAttributes;
    all[5] = ssENSupplierUser.OptimizedAttributes;
    all[6] = ssENCompany.OptimizedAttributes;
    all[7] = ssENApprovalProcessType.OptimizedAttributes;
    all[8] = ssENSupplier.OptimizedAttributes;
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
ssENUser.Read( r, ref index);
ssENFolioStatus.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENSupplierUser.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENApprovalProcessType.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_def4a4b06f199364b3c4464c2355286a r) {
this = r;
}


public static bool operator == (RC_def4a4b06f199364b3c4464c2355286a a, RC_def4a4b06f199364b3c4464c2355286a b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENFolioStatus != b.ssENFolioStatus) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENSupplierUser != b.ssENSupplierUser) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENApprovalProcessType != b.ssENApprovalProcessType) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_def4a4b06f199364b3c4464c2355286a a, RC_def4a4b06f199364b3c4464c2355286a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_def4a4b06f199364b3c4464c2355286a)) return false;
return (this == (RC_def4a4b06f199364b3c4464c2355286a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENFolioStatus.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENSupplierUser.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENApprovalProcessType.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENUser.RecursiveReset();
ssENFolioStatus.RecursiveReset();
ssENFolio.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENSupplierUser.RecursiveReset();
ssENCompany.RecursiveReset();
ssENApprovalProcessType.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENUser.InternalRecursiveSave();
ssENFolioStatus.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENSupplierUser.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENApprovalProcessType.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_def4a4b06f199364b3c4464c2355286a Duplicate() {
RC_def4a4b06f199364b3c4464c2355286a t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENFolioStatus = (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord)this.ssENFolioStatus.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENSupplierUser = (EN_360367a38fba8439556dd1e5826e0428EntityRecord)this.ssENSupplierUser.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENApprovalProcessType = (EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord)this.ssENApprovalProcessType.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
} else if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "foliostatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioStatus")) variable.Value = ssENFolioStatus; else variable.Optimized = true;
variable.SetFieldName("foliostatus");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "supplieruser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierUser")) variable.Value = ssENSupplierUser; else variable.Optimized = true;
variable.SetFieldName("supplieruser");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "approvalprocesstype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessType")) variable.Value = ssENApprovalProcessType; else variable.Optimized = true;
variable.SetFieldName("approvalprocesstype");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdFolioStatus) {
return ssENFolioStatus;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdSupplierUser) {
return ssENSupplierUser;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdApprovalProcessType) {
return ssENApprovalProcessType;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdFolioStatus.Key.AsGuid) {
return ssENFolioStatus;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdSupplierUser.Key.AsGuid) {
return ssENSupplierUser;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdApprovalProcessType.Key.AsGuid) {
return ssENApprovalProcessType;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENFolioStatus.FillFromOther((IRecord) other.AttributeGet(IdFolioStatus));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENSupplierUser.FillFromOther((IRecord) other.AttributeGet(IdSupplierUser));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENApprovalProcessType.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessType));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_def4a4b06f199364b3c4464c2355286a
/// <summary>
/// RecordList type
///  <code>CurrencyUserFolioStatusFolioOrderMainSupplierUserCompanyApprovalProcessTypeSupplierRecordList
/// </code> that represents a record list of <code>Currency, User, FolioStatus, Folio, OrderMain,
///  SupplierUser, Company, ApprovalProcessType, Supplier</code>
/// </summary>
public partial class RL_fbe5076a8f56e344f72f9258ea487c5d : GenericRecordList<RC_def4a4b06f199364b3c4464c2355286a>, IEnumerable, IEnumerator {

protected override RC_def4a4b06f199364b3c4464c2355286a GetElementDefaultValue() {
return new RC_def4a4b06f199364b3c4464c2355286a();
}

public T[] ToArray<T>(Func<RC_def4a4b06f199364b3c4464c2355286a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fbe5076a8f56e344f72f9258ea487c5d recordList, Func<RC_def4a4b06f199364b3c4464c2355286a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fbe5076a8f56e344f72f9258ea487c5d(RC_def4a4b06f199364b3c4464c2355286a[] array) {
  RL_fbe5076a8f56e344f72f9258ea487c5d result = new RL_fbe5076a8f56e344f72f9258ea487c5d();
result.InnerFromArray(array);
    return result;
}

public static RL_fbe5076a8f56e344f72f9258ea487c5d ToList<T>(T[] array, Func <T, RC_def4a4b06f199364b3c4464c2355286a> converter) {
  RL_fbe5076a8f56e344f72f9258ea487c5d result = new RL_fbe5076a8f56e344f72f9258ea487c5d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fbe5076a8f56e344f72f9258ea487c5d FromRestList<T>(RestList<T> restList, Func <T, RC_def4a4b06f199364b3c4464c2355286a> converter) {
  RL_fbe5076a8f56e344f72f9258ea487c5d result = new RL_fbe5076a8f56e344f72f9258ea487c5d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fbe5076a8f56e344f72f9258ea487c5d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[9];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(6,false);
def[3] = new BitArray(20,false);
def[4] = new BitArray(29,false);
def[5] = new BitArray(15,false);
def[6] = new BitArray(11,false);
def[7] = new BitArray(5,false);
def[8] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_def4a4b06f199364b3c4464c2355286a> NewList() {
return new RL_fbe5076a8f56e344f72f9258ea487c5d();
}


} // RL_fbe5076a8f56e344f72f9258ea487c5d
}

