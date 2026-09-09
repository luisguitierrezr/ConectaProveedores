namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2OxSsNAttUCBQpucptoq6w)
///  <code>RC_12d88e24134057c9d8b3dfc84a66166f</code> that represent
/// s
///  <code>User_ApprovedUser_AssignedOrderApprovalOrderComment_CancelOrderComment_ModifyOrderMainOrderAp
/// provalLevelEntraRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: User_ApprovedUser_AssignedOrderApprovalOrderComment_CancelOrderComment_ModifyOrderMainOrderApprovalLevelEntraRoleRecord
public partial struct RC_12d88e24134057c9d8b3dfc84a66166f : ITypedRecord<RC_12d88e24134057c9d8b3dfc84a66166f> {
internal static readonly GlobalObjectKey IdUser_Approved = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*i+Lhj9jIQWOOlLyP_LMf_w");
internal static readonly GlobalObjectKey IdUser_Assigned = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CZjl_1p6AoxYi45ACvvWaw");
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderComment_Cancel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zsSRdreu2IKBiWXWeAB78g");
internal static readonly GlobalObjectKey IdOrderComment_Modify = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zeIXVoyB1wNj2OHNd3xjmQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");

public ENUserEntityRecord ssENUser_Approved;

public ENUserEntityRecord ssENUser_Assigned;

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord ssENOrderComment_Cancel;

public EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord ssENOrderComment_Modify;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;


public BitArray OptimizedAttributes;

public RC_12d88e24134057c9d8b3dfc84a66166f() {
OptimizedAttributes = null;
ssENUser_Approved = new ENUserEntityRecord();
ssENUser_Assigned = new ENUserEntityRecord();
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderComment_Cancel = new EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord();
ssENOrderComment_Modify = new EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(8,false);
    all[3] = new BitArray(7,false);
    all[4] = new BitArray(7,false);
    all[5] = new BitArray(29,false);
    all[6] = new BitArray(17,false);
    all[7] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser_Approved.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Assigned.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderComment_Cancel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderComment_Modify.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENUser_Approved.OptimizedAttributes = value[0];
    ssENUser_Assigned.OptimizedAttributes = value[1];
    ssENOrderApproval.OptimizedAttributes = value[2];
    ssENOrderComment_Cancel.OptimizedAttributes = value[3];
    ssENOrderComment_Modify.OptimizedAttributes = value[4];
    ssENOrderMain.OptimizedAttributes = value[5];
    ssENOrderApprovalLevel.OptimizedAttributes = value[6];
    ssENEntraRole.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENUser_Approved.OptimizedAttributes;
    all[1] = ssENUser_Assigned.OptimizedAttributes;
    all[2] = ssENOrderApproval.OptimizedAttributes;
    all[3] = ssENOrderComment_Cancel.OptimizedAttributes;
    all[4] = ssENOrderComment_Modify.OptimizedAttributes;
    all[5] = ssENOrderMain.OptimizedAttributes;
    all[6] = ssENOrderApprovalLevel.OptimizedAttributes;
    all[7] = ssENEntraRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser_Approved.Read( r, ref index);
ssENUser_Assigned.Read( r, ref index);
ssENOrderApproval.Read( r, ref index);
ssENOrderComment_Cancel.Read( r, ref index);
ssENOrderComment_Modify.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
ssENEntraRole.Read( r, ref index);
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
public void ReadIM(RC_12d88e24134057c9d8b3dfc84a66166f r) {
this = r;
}


public static bool operator == (RC_12d88e24134057c9d8b3dfc84a66166f a, RC_12d88e24134057c9d8b3dfc84a66166f b) {
if (a.ssENUser_Approved != b.ssENUser_Approved) return false;
if (a.ssENUser_Assigned != b.ssENUser_Assigned) return false;
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderComment_Cancel != b.ssENOrderComment_Cancel) return false;
if (a.ssENOrderComment_Modify != b.ssENOrderComment_Modify) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
return true;
}

public static bool operator != (RC_12d88e24134057c9d8b3dfc84a66166f a, RC_12d88e24134057c9d8b3dfc84a66166f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_12d88e24134057c9d8b3dfc84a66166f)) return false;
return (this == (RC_12d88e24134057c9d8b3dfc84a66166f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser_Approved.GetHashCode()
 ^ ssENUser_Assigned.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderComment_Cancel.GetHashCode()
 ^ ssENOrderComment_Modify.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser_Approved.RecursiveReset();
ssENUser_Assigned.RecursiveReset();
ssENOrderApproval.RecursiveReset();
ssENOrderComment_Cancel.RecursiveReset();
ssENOrderComment_Modify.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
ssENEntraRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser_Approved.InternalRecursiveSave();
ssENUser_Assigned.InternalRecursiveSave();
ssENOrderApproval.InternalRecursiveSave();
ssENOrderComment_Cancel.InternalRecursiveSave();
ssENOrderComment_Modify.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
}


public RC_12d88e24134057c9d8b3dfc84a66166f Duplicate() {
RC_12d88e24134057c9d8b3dfc84a66166f t;
t.ssENUser_Approved = (ENUserEntityRecord)this.ssENUser_Approved.Duplicate();
t.ssENUser_Assigned = (ENUserEntityRecord)this.ssENUser_Assigned.Duplicate();
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderComment_Cancel = (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord)this.ssENOrderComment_Cancel.Duplicate();
t.ssENOrderComment_Modify = (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord)this.ssENOrderComment_Modify.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
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
if (head == "user_approved") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Approved")) variable.Value = ssENUser_Approved; else variable.Optimized = true;
variable.SetFieldName("user_approved");
} else if (head == "user_assigned") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Assigned")) variable.Value = ssENUser_Assigned; else variable.Optimized = true;
variable.SetFieldName("user_assigned");
} else if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
} else if (head == "ordercomment_cancel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderComment_Cancel")) variable.Value = ssENOrderComment_Cancel; else variable.Optimized = true;
variable.SetFieldName("ordercomment_cancel");
} else if (head == "ordercomment_modify") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderComment_Modify")) variable.Value = ssENOrderComment_Modify; else variable.Optimized = true;
variable.SetFieldName("ordercomment_modify");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
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
if (key == IdUser_Approved) {
return ssENUser_Approved;
}
if (key == IdUser_Assigned) {
return ssENUser_Assigned;
}
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
if (key == IdOrderComment_Cancel) {
return ssENOrderComment_Cancel;
}
if (key == IdOrderComment_Modify) {
return ssENOrderComment_Modify;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
}
if (key == IdEntraRole) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser_Approved.Key.AsGuid) {
return ssENUser_Approved;
}
if (attributeKey == IdUser_Assigned.Key.AsGuid) {
return ssENUser_Assigned;
}
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
if (attributeKey == IdOrderComment_Cancel.Key.AsGuid) {
return ssENOrderComment_Cancel;
}
if (attributeKey == IdOrderComment_Modify.Key.AsGuid) {
return ssENOrderComment_Modify;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser_Approved.FillFromOther((IRecord) other.AttributeGet(IdUser_Approved));
ssENUser_Assigned.FillFromOther((IRecord) other.AttributeGet(IdUser_Assigned));
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderComment_Cancel.FillFromOther((IRecord) other.AttributeGet(IdOrderComment_Cancel));
ssENOrderComment_Modify.FillFromOther((IRecord) other.AttributeGet(IdOrderComment_Modify));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
}
} // RC_12d88e24134057c9d8b3dfc84a66166f
/// <summary>
/// RecordList type
///  <code>User_ApprovedUser_AssignedOrderApprovalOrderComment_CancelOrderComment_ModifyOrderMainOrderAp
/// provalLevelEntraRoleRecordList</code> that represents a record list of <code>User, User,
///  OrderApproval, OrderComment, OrderComment, OrderMain, OrderApprovalLevel, EntraRole</code>
/// </summary>
public partial class RL_e7b917e1824eb68e8cf92fc307d1415d : GenericRecordList<RC_12d88e24134057c9d8b3dfc84a66166f>, IEnumerable, IEnumerator {

protected override RC_12d88e24134057c9d8b3dfc84a66166f GetElementDefaultValue() {
return new RC_12d88e24134057c9d8b3dfc84a66166f();
}

public T[] ToArray<T>(Func<RC_12d88e24134057c9d8b3dfc84a66166f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e7b917e1824eb68e8cf92fc307d1415d recordList, Func<RC_12d88e24134057c9d8b3dfc84a66166f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e7b917e1824eb68e8cf92fc307d1415d(RC_12d88e24134057c9d8b3dfc84a66166f[] array) {
  RL_e7b917e1824eb68e8cf92fc307d1415d result = new RL_e7b917e1824eb68e8cf92fc307d1415d();
result.InnerFromArray(array);
    return result;
}

public static RL_e7b917e1824eb68e8cf92fc307d1415d ToList<T>(T[] array, Func <T, RC_12d88e24134057c9d8b3dfc84a66166f> converter) {
  RL_e7b917e1824eb68e8cf92fc307d1415d result = new RL_e7b917e1824eb68e8cf92fc307d1415d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e7b917e1824eb68e8cf92fc307d1415d FromRestList<T>(RestList<T> restList, Func <T, RC_12d88e24134057c9d8b3dfc84a66166f> converter) {
  RL_e7b917e1824eb68e8cf92fc307d1415d result = new RL_e7b917e1824eb68e8cf92fc307d1415d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e7b917e1824eb68e8cf92fc307d1415d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(8,false);
def[3] = new BitArray(7,false);
def[4] = new BitArray(7,false);
def[5] = new BitArray(29,false);
def[6] = new BitArray(17,false);
def[7] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_12d88e24134057c9d8b3dfc84a66166f> NewList() {
return new RL_e7b917e1824eb68e8cf92fc307d1415d();
}


} // RL_e7b917e1824eb68e8cf92fc307d1415d
}

