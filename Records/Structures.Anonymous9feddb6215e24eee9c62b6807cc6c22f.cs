namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Ytvtn+IV7k6cYraAfMbCLw)
///  <code>RC_0a31a39e5189fa78e8cbab87cf47752b</code> that represent
/// s
///  <code>UserInvoiceOrderRequestFileApprovalOrderRequestFileApprovalLevelInvoiceStatusApprovalStatusOr
/// derRequestFileOrderMainEntraRoleStorageRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceOrderRequestFileApprovalOrderRequestFileApprovalLevelInvoiceStatusApprovalStatusOrderRequestFileOrderMainEntraRoleStorageRecord
public partial struct RC_0a31a39e5189fa78e8cbab87cf47752b : ITypedRecord<RC_0a31a39e5189fa78e8cbab87cf47752b> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdOrderRequestFileApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*igvHZHI_KNE_GKPaj46z1Q");
internal static readonly GlobalObjectKey IdOrderRequestFileApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CgSm2lumwlVXTmpOl2dmzg");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdOrderRequestFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bBLYcy5yTSvWYtqyvxpy0Q");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");

public ENUserEntityRecord ssENUser;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_1710c672f4d7138b664ee1411114271eEntityRecord ssENOrderRequestFileApproval;

public EN_80af67ecab8f43d464cc57955285a024EntityRecord ssENOrderRequestFileApprovalLevel;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;


public BitArray OptimizedAttributes;

public RC_0a31a39e5189fa78e8cbab87cf47752b() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENOrderRequestFileApproval = new EN_1710c672f4d7138b664ee1411114271eEntityRecord();
ssENOrderRequestFileApprovalLevel = new EN_80af67ecab8f43d464cc57955285a024EntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[10];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(6,false);
    all[3] = new BitArray(12,false);
    all[4] = new BitArray(7,false);
    all[5] = new BitArray(10,false);
    all[6] = new BitArray(17,false);
    all[7] = new BitArray(29,false);
    all[8] = new BitArray(6,false);
    all[9] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderRequestFileApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderRequestFileApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENOrderRequestFile.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENOrderRequestFileApproval.OptimizedAttributes = value[2];
    ssENOrderRequestFileApprovalLevel.OptimizedAttributes = value[3];
    ssENInvoiceStatus.OptimizedAttributes = value[4];
    ssENApprovalStatus.OptimizedAttributes = value[5];
    ssENOrderRequestFile.OptimizedAttributes = value[6];
    ssENOrderMain.OptimizedAttributes = value[7];
    ssENEntraRole.OptimizedAttributes = value[8];
    ssENStorage.OptimizedAttributes = value[9];
    }
}
get{
    BitArray[] all = new BitArray[10];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENOrderRequestFileApproval.OptimizedAttributes;
    all[3] = ssENOrderRequestFileApprovalLevel.OptimizedAttributes;
    all[4] = ssENInvoiceStatus.OptimizedAttributes;
    all[5] = ssENApprovalStatus.OptimizedAttributes;
    all[6] = ssENOrderRequestFile.OptimizedAttributes;
    all[7] = ssENOrderMain.OptimizedAttributes;
    all[8] = ssENEntraRole.OptimizedAttributes;
    all[9] = ssENStorage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENOrderRequestFileApproval.Read( r, ref index);
ssENOrderRequestFileApprovalLevel.Read( r, ref index);
ssENInvoiceStatus.Read( r, ref index);
ssENApprovalStatus.Read( r, ref index);
ssENOrderRequestFile.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENEntraRole.Read( r, ref index);
ssENStorage.Read( r, ref index);
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
public void ReadIM(RC_0a31a39e5189fa78e8cbab87cf47752b r) {
this = r;
}


public static bool operator == (RC_0a31a39e5189fa78e8cbab87cf47752b a, RC_0a31a39e5189fa78e8cbab87cf47752b b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENOrderRequestFileApproval != b.ssENOrderRequestFileApproval) return false;
if (a.ssENOrderRequestFileApprovalLevel != b.ssENOrderRequestFileApprovalLevel) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENOrderRequestFile != b.ssENOrderRequestFile) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENStorage != b.ssENStorage) return false;
return true;
}

public static bool operator != (RC_0a31a39e5189fa78e8cbab87cf47752b a, RC_0a31a39e5189fa78e8cbab87cf47752b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0a31a39e5189fa78e8cbab87cf47752b)) return false;
return (this == (RC_0a31a39e5189fa78e8cbab87cf47752b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENOrderRequestFileApproval.GetHashCode()
 ^ ssENOrderRequestFileApprovalLevel.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENOrderRequestFile.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENOrderRequestFileApproval.RecursiveReset();
ssENOrderRequestFileApprovalLevel.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
ssENApprovalStatus.RecursiveReset();
ssENOrderRequestFile.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENOrderRequestFileApproval.InternalRecursiveSave();
ssENOrderRequestFileApprovalLevel.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
ssENApprovalStatus.InternalRecursiveSave();
ssENOrderRequestFile.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
}


public RC_0a31a39e5189fa78e8cbab87cf47752b Duplicate() {
RC_0a31a39e5189fa78e8cbab87cf47752b t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENOrderRequestFileApproval = (EN_1710c672f4d7138b664ee1411114271eEntityRecord)this.ssENOrderRequestFileApproval.Duplicate();
t.ssENOrderRequestFileApprovalLevel = (EN_80af67ecab8f43d464cc57955285a024EntityRecord)this.ssENOrderRequestFileApprovalLevel.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
t.ssENOrderRequestFile = (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)this.ssENOrderRequestFile.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
t.ssENStorage = (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)this.ssENStorage.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "orderrequestfileapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileApproval")) variable.Value = ssENOrderRequestFileApproval; else variable.Optimized = true;
variable.SetFieldName("orderrequestfileapproval");
} else if (head == "orderrequestfileapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileApprovalLevel")) variable.Value = ssENOrderRequestFileApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderrequestfileapprovallevel");
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
} else if (head == "approvalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatus")) variable.Value = ssENApprovalStatus; else variable.Optimized = true;
variable.SetFieldName("approvalstatus");
} else if (head == "orderrequestfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFile")) variable.Value = ssENOrderRequestFile; else variable.Optimized = true;
variable.SetFieldName("orderrequestfile");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
} else if (head == "storage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Storage")) variable.Value = ssENStorage; else variable.Optimized = true;
variable.SetFieldName("storage");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdOrderRequestFileApproval) {
return ssENOrderRequestFileApproval;
}
if (key == IdOrderRequestFileApprovalLevel) {
return ssENOrderRequestFileApprovalLevel;
}
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
}
if (key == IdApprovalStatus) {
return ssENApprovalStatus;
}
if (key == IdOrderRequestFile) {
return ssENOrderRequestFile;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdEntraRole) {
return ssENEntraRole;
}
if (key == IdStorage) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdOrderRequestFileApproval.Key.AsGuid) {
return ssENOrderRequestFileApproval;
}
if (attributeKey == IdOrderRequestFileApprovalLevel.Key.AsGuid) {
return ssENOrderRequestFileApprovalLevel;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
}
if (attributeKey == IdApprovalStatus.Key.AsGuid) {
return ssENApprovalStatus;
}
if (attributeKey == IdOrderRequestFile.Key.AsGuid) {
return ssENOrderRequestFile;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
if (attributeKey == IdStorage.Key.AsGuid) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENOrderRequestFileApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileApproval));
ssENOrderRequestFileApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileApprovalLevel));
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENOrderRequestFile.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFile));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
}
} // RC_0a31a39e5189fa78e8cbab87cf47752b
/// <summary>
/// RecordList type
///  <code>UserInvoiceOrderRequestFileApprovalOrderRequestFileApprovalLevelInvoiceStatusApprovalStatusOr
/// derRequestFileOrderMainEntraRoleStorageRecordList</code> that represents a record list of
///  <code>User, Invoice, OrderRequestFileApproval, OrderRequestFileApprovalLevel, InvoiceStatus
/// , ApprovalStatus, OrderRequestFile, OrderMain, EntraRole, Storage</code>
/// </summary>
public partial class RL_973c3440756f350a5cffc50d9d6bb1d9 : GenericRecordList<RC_0a31a39e5189fa78e8cbab87cf47752b>, IEnumerable, IEnumerator {

protected override RC_0a31a39e5189fa78e8cbab87cf47752b GetElementDefaultValue() {
return new RC_0a31a39e5189fa78e8cbab87cf47752b();
}

public T[] ToArray<T>(Func<RC_0a31a39e5189fa78e8cbab87cf47752b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_973c3440756f350a5cffc50d9d6bb1d9 recordList, Func<RC_0a31a39e5189fa78e8cbab87cf47752b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_973c3440756f350a5cffc50d9d6bb1d9(RC_0a31a39e5189fa78e8cbab87cf47752b[] array) {
  RL_973c3440756f350a5cffc50d9d6bb1d9 result = new RL_973c3440756f350a5cffc50d9d6bb1d9();
result.InnerFromArray(array);
    return result;
}

public static RL_973c3440756f350a5cffc50d9d6bb1d9 ToList<T>(T[] array, Func <T, RC_0a31a39e5189fa78e8cbab87cf47752b> converter) {
  RL_973c3440756f350a5cffc50d9d6bb1d9 result = new RL_973c3440756f350a5cffc50d9d6bb1d9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_973c3440756f350a5cffc50d9d6bb1d9 FromRestList<T>(RestList<T> restList, Func <T, RC_0a31a39e5189fa78e8cbab87cf47752b> converter) {
  RL_973c3440756f350a5cffc50d9d6bb1d9 result = new RL_973c3440756f350a5cffc50d9d6bb1d9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_973c3440756f350a5cffc50d9d6bb1d9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[10];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(6,false);
def[3] = new BitArray(12,false);
def[4] = new BitArray(7,false);
def[5] = new BitArray(10,false);
def[6] = new BitArray(17,false);
def[7] = new BitArray(29,false);
def[8] = new BitArray(6,false);
def[9] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0a31a39e5189fa78e8cbab87cf47752b> NewList() {
return new RL_973c3440756f350a5cffc50d9d6bb1d9();
}


} // RL_973c3440756f350a5cffc50d9d6bb1d9
}

