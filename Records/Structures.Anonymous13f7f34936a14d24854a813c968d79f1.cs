namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (SfP3E6E2JE2FSoE8lo158Q)
///  <code>RC_024e9a829fffe4bfa83b0fabfeeda355</code> that represent
/// s
///  <code>CurrencyUserOrderStatusOrderRequestFileApprovalOrderRequestFileApprovalLevelApprovalStatusOrd
/// erRequestFileOrderMainEntraRoleCompanyRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyUserOrderStatusOrderRequestFileApprovalOrderRequestFileApprovalLevelApprovalStatusOrderRequestFileOrderMainEntraRoleCompanyRecord
public partial struct RC_024e9a829fffe4bfa83b0fabfeeda355 : ITypedRecord<RC_024e9a829fffe4bfa83b0fabfeeda355> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");
internal static readonly GlobalObjectKey IdOrderRequestFileApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*igvHZHI_KNE_GKPaj46z1Q");
internal static readonly GlobalObjectKey IdOrderRequestFileApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CgSm2lumwlVXTmpOl2dmzg");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdOrderRequestFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bBLYcy5yTSvWYtqyvxpy0Q");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public ENUserEntityRecord ssENUser;

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;

public EN_1710c672f4d7138b664ee1411114271eEntityRecord ssENOrderRequestFileApproval;

public EN_80af67ecab8f43d464cc57955285a024EntityRecord ssENOrderRequestFileApprovalLevel;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;


public BitArray OptimizedAttributes;

public RC_024e9a829fffe4bfa83b0fabfeeda355() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENUser = new ENUserEntityRecord();
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
ssENOrderRequestFileApproval = new EN_1710c672f4d7138b664ee1411114271eEntityRecord();
ssENOrderRequestFileApprovalLevel = new EN_80af67ecab8f43d464cc57955285a024EntityRecord();
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[10];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(6,false);
    all[3] = new BitArray(6,false);
    all[4] = new BitArray(12,false);
    all[5] = new BitArray(10,false);
    all[6] = new BitArray(17,false);
    all[7] = new BitArray(29,false);
    all[8] = new BitArray(6,false);
    all[9] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderRequestFileApproval.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderRequestFileApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENOrderRequestFile.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENUser.OptimizedAttributes = value[1];
    ssENOrderStatus.OptimizedAttributes = value[2];
    ssENOrderRequestFileApproval.OptimizedAttributes = value[3];
    ssENOrderRequestFileApprovalLevel.OptimizedAttributes = value[4];
    ssENApprovalStatus.OptimizedAttributes = value[5];
    ssENOrderRequestFile.OptimizedAttributes = value[6];
    ssENOrderMain.OptimizedAttributes = value[7];
    ssENEntraRole.OptimizedAttributes = value[8];
    ssENCompany.OptimizedAttributes = value[9];
    }
}
get{
    BitArray[] all = new BitArray[10];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENUser.OptimizedAttributes;
    all[2] = ssENOrderStatus.OptimizedAttributes;
    all[3] = ssENOrderRequestFileApproval.OptimizedAttributes;
    all[4] = ssENOrderRequestFileApprovalLevel.OptimizedAttributes;
    all[5] = ssENApprovalStatus.OptimizedAttributes;
    all[6] = ssENOrderRequestFile.OptimizedAttributes;
    all[7] = ssENOrderMain.OptimizedAttributes;
    all[8] = ssENEntraRole.OptimizedAttributes;
    all[9] = ssENCompany.OptimizedAttributes;
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
ssENOrderStatus.Read( r, ref index);
ssENOrderRequestFileApproval.Read( r, ref index);
ssENOrderRequestFileApprovalLevel.Read( r, ref index);
ssENApprovalStatus.Read( r, ref index);
ssENOrderRequestFile.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENEntraRole.Read( r, ref index);
ssENCompany.Read( r, ref index);
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
public void ReadIM(RC_024e9a829fffe4bfa83b0fabfeeda355 r) {
this = r;
}


public static bool operator == (RC_024e9a829fffe4bfa83b0fabfeeda355 a, RC_024e9a829fffe4bfa83b0fabfeeda355 b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
if (a.ssENOrderRequestFileApproval != b.ssENOrderRequestFileApproval) return false;
if (a.ssENOrderRequestFileApprovalLevel != b.ssENOrderRequestFileApprovalLevel) return false;
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENOrderRequestFile != b.ssENOrderRequestFile) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENCompany != b.ssENCompany) return false;
return true;
}

public static bool operator != (RC_024e9a829fffe4bfa83b0fabfeeda355 a, RC_024e9a829fffe4bfa83b0fabfeeda355 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_024e9a829fffe4bfa83b0fabfeeda355)) return false;
return (this == (RC_024e9a829fffe4bfa83b0fabfeeda355)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
 ^ ssENOrderRequestFileApproval.GetHashCode()
 ^ ssENOrderRequestFileApprovalLevel.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENOrderRequestFile.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENCompany.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENUser.RecursiveReset();
ssENOrderStatus.RecursiveReset();
ssENOrderRequestFileApproval.RecursiveReset();
ssENOrderRequestFileApprovalLevel.RecursiveReset();
ssENApprovalStatus.RecursiveReset();
ssENOrderRequestFile.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENCompany.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENUser.InternalRecursiveSave();
ssENOrderStatus.InternalRecursiveSave();
ssENOrderRequestFileApproval.InternalRecursiveSave();
ssENOrderRequestFileApprovalLevel.InternalRecursiveSave();
ssENApprovalStatus.InternalRecursiveSave();
ssENOrderRequestFile.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
}


public RC_024e9a829fffe4bfa83b0fabfeeda355 Duplicate() {
RC_024e9a829fffe4bfa83b0fabfeeda355 t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
t.ssENOrderRequestFileApproval = (EN_1710c672f4d7138b664ee1411114271eEntityRecord)this.ssENOrderRequestFileApproval.Duplicate();
t.ssENOrderRequestFileApprovalLevel = (EN_80af67ecab8f43d464cc57955285a024EntityRecord)this.ssENOrderRequestFileApprovalLevel.Duplicate();
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
t.ssENOrderRequestFile = (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)this.ssENOrderRequestFile.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
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
} else if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssENOrderStatus; else variable.Optimized = true;
variable.SetFieldName("orderstatus");
} else if (head == "orderrequestfileapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileApproval")) variable.Value = ssENOrderRequestFileApproval; else variable.Optimized = true;
variable.SetFieldName("orderrequestfileapproval");
} else if (head == "orderrequestfileapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileApprovalLevel")) variable.Value = ssENOrderRequestFileApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderrequestfileapprovallevel");
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
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
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
if (key == IdOrderStatus) {
return ssENOrderStatus;
}
if (key == IdOrderRequestFileApproval) {
return ssENOrderRequestFileApproval;
}
if (key == IdOrderRequestFileApprovalLevel) {
return ssENOrderRequestFileApprovalLevel;
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
if (key == IdCompany) {
return ssENCompany;
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
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssENOrderStatus;
}
if (attributeKey == IdOrderRequestFileApproval.Key.AsGuid) {
return ssENOrderRequestFileApproval;
}
if (attributeKey == IdOrderRequestFileApprovalLevel.Key.AsGuid) {
return ssENOrderRequestFileApprovalLevel;
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
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
ssENOrderRequestFileApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileApproval));
ssENOrderRequestFileApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileApprovalLevel));
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENOrderRequestFile.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFile));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
}
} // RC_024e9a829fffe4bfa83b0fabfeeda355
/// <summary>
/// RecordList type
///  <code>CurrencyUserOrderStatusOrderRequestFileApprovalOrderRequestFileApprovalLevelApprovalStatusOrd
/// erRequestFileOrderMainEntraRoleCompanyRecordList</code> that represents a record list of
///  <code>Currency, User, OrderStatus, OrderRequestFileApproval, OrderRequestFileApprovalLevel
/// , ApprovalStatus, OrderRequestFile, OrderMain, EntraRole, Company</code>
/// </summary>
public partial class RL_db0d38b1aac3f81b1d514ccc9e6030e5 : GenericRecordList<RC_024e9a829fffe4bfa83b0fabfeeda355>, IEnumerable, IEnumerator {

protected override RC_024e9a829fffe4bfa83b0fabfeeda355 GetElementDefaultValue() {
return new RC_024e9a829fffe4bfa83b0fabfeeda355();
}

public T[] ToArray<T>(Func<RC_024e9a829fffe4bfa83b0fabfeeda355, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_db0d38b1aac3f81b1d514ccc9e6030e5 recordList, Func<RC_024e9a829fffe4bfa83b0fabfeeda355, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_db0d38b1aac3f81b1d514ccc9e6030e5(RC_024e9a829fffe4bfa83b0fabfeeda355[] array) {
  RL_db0d38b1aac3f81b1d514ccc9e6030e5 result = new RL_db0d38b1aac3f81b1d514ccc9e6030e5();
result.InnerFromArray(array);
    return result;
}

public static RL_db0d38b1aac3f81b1d514ccc9e6030e5 ToList<T>(T[] array, Func <T, RC_024e9a829fffe4bfa83b0fabfeeda355> converter) {
  RL_db0d38b1aac3f81b1d514ccc9e6030e5 result = new RL_db0d38b1aac3f81b1d514ccc9e6030e5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_db0d38b1aac3f81b1d514ccc9e6030e5 FromRestList<T>(RestList<T> restList, Func <T, RC_024e9a829fffe4bfa83b0fabfeeda355> converter) {
  RL_db0d38b1aac3f81b1d514ccc9e6030e5 result = new RL_db0d38b1aac3f81b1d514ccc9e6030e5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_db0d38b1aac3f81b1d514ccc9e6030e5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[10];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(6,false);
def[3] = new BitArray(6,false);
def[4] = new BitArray(12,false);
def[5] = new BitArray(10,false);
def[6] = new BitArray(17,false);
def[7] = new BitArray(29,false);
def[8] = new BitArray(6,false);
def[9] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_024e9a829fffe4bfa83b0fabfeeda355> NewList() {
return new RL_db0d38b1aac3f81b1d514ccc9e6030e5();
}


} // RL_db0d38b1aac3f81b1d514ccc9e6030e5
}

