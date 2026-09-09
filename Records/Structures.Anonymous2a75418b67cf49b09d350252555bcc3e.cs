namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (i0F1Ks9nsEmdNQJSVVvMPg)
///  <code>RC_a5e9a82dc9980e7d5c34d4c26f706ace</code> that represent
/// s
///  <code>ApproverOrderApprovalOrderMainOrderApprovalLevelUserExtensionUser_Extended_InternalRecord</co
/// de> <p>Description: </p>
/// </summary>
// Name: ApproverOrderApprovalOrderMainOrderApprovalLevelUserExtensionUser_Extended_InternalRecord
public partial struct RC_a5e9a82dc9980e7d5c34d4c26f706ace : ITypedRecord<RC_a5e9a82dc9980e7d5c34d4c26f706ace> {
internal static readonly GlobalObjectKey IdApprover = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*l6irSmxfBywpC1YH_lLNLA");
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENApprover;

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_a5e9a82dc9980e7d5c34d4c26f706ace() {
OptimizedAttributes = null;
ssENApprover = new ENUserEntityRecord();
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(29,false);
    all[3] = new BitArray(17,false);
    all[4] = new BitArray(3,false);
    all[5] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprover.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENApprover.OptimizedAttributes = value[0];
    ssENOrderApproval.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssENOrderApprovalLevel.OptimizedAttributes = value[3];
    ssENUserExtension.OptimizedAttributes = value[4];
    ssENUser_Extended_Internal.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENApprover.OptimizedAttributes;
    all[1] = ssENOrderApproval.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = ssENOrderApprovalLevel.OptimizedAttributes;
    all[4] = ssENUserExtension.OptimizedAttributes;
    all[5] = ssENUser_Extended_Internal.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApprover.Read( r, ref index);
ssENOrderApproval.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
ssENUserExtension.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
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
public void ReadIM(RC_a5e9a82dc9980e7d5c34d4c26f706ace r) {
this = r;
}


public static bool operator == (RC_a5e9a82dc9980e7d5c34d4c26f706ace a, RC_a5e9a82dc9980e7d5c34d4c26f706ace b) {
if (a.ssENApprover != b.ssENApprover) return false;
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_a5e9a82dc9980e7d5c34d4c26f706ace a, RC_a5e9a82dc9980e7d5c34d4c26f706ace b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a5e9a82dc9980e7d5c34d4c26f706ace)) return false;
return (this == (RC_a5e9a82dc9980e7d5c34d4c26f706ace)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprover.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprover.RecursiveReset();
ssENOrderApproval.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
ssENUserExtension.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprover.InternalRecursiveSave();
ssENOrderApproval.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_a5e9a82dc9980e7d5c34d4c26f706ace Duplicate() {
RC_a5e9a82dc9980e7d5c34d4c26f706ace t;
t.ssENApprover = (ENUserEntityRecord)this.ssENApprover.Duplicate();
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
t.ssENUserExtension = (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)this.ssENUserExtension.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
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
if (head == "approver") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Approver")) variable.Value = ssENApprover; else variable.Optimized = true;
variable.SetFieldName("approver");
} else if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
} else if (head == "userextension") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserExtension")) variable.Value = ssENUserExtension; else variable.Optimized = true;
variable.SetFieldName("userextension");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
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
if (key == IdApprover) {
return ssENApprover;
}
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
}
if (key == IdUserExtension) {
return ssENUserExtension;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprover.Key.AsGuid) {
return ssENApprover;
}
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
if (attributeKey == IdUserExtension.Key.AsGuid) {
return ssENUserExtension;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprover.FillFromOther((IRecord) other.AttributeGet(IdApprover));
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_a5e9a82dc9980e7d5c34d4c26f706ace
/// <summary>
/// RecordList type
///  <code>ApproverOrderApprovalOrderMainOrderApprovalLevelUserExtensionUser_Extended_InternalRecordList
/// </code> that represents a record list of <code>User, OrderApproval, OrderMain, OrderApprovalLevel,
///  UserExtension, User_Extended_Internal</code>
/// </summary>
public partial class RL_a351086105893ea080eb7f2ace0f714d : GenericRecordList<RC_a5e9a82dc9980e7d5c34d4c26f706ace>, IEnumerable, IEnumerator {

protected override RC_a5e9a82dc9980e7d5c34d4c26f706ace GetElementDefaultValue() {
return new RC_a5e9a82dc9980e7d5c34d4c26f706ace();
}

public T[] ToArray<T>(Func<RC_a5e9a82dc9980e7d5c34d4c26f706ace, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a351086105893ea080eb7f2ace0f714d recordList, Func<RC_a5e9a82dc9980e7d5c34d4c26f706ace, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a351086105893ea080eb7f2ace0f714d(RC_a5e9a82dc9980e7d5c34d4c26f706ace[] array) {
  RL_a351086105893ea080eb7f2ace0f714d result = new RL_a351086105893ea080eb7f2ace0f714d();
result.InnerFromArray(array);
    return result;
}

public static RL_a351086105893ea080eb7f2ace0f714d ToList<T>(T[] array, Func <T, RC_a5e9a82dc9980e7d5c34d4c26f706ace> converter) {
  RL_a351086105893ea080eb7f2ace0f714d result = new RL_a351086105893ea080eb7f2ace0f714d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a351086105893ea080eb7f2ace0f714d FromRestList<T>(RestList<T> restList, Func <T, RC_a5e9a82dc9980e7d5c34d4c26f706ace> converter) {
  RL_a351086105893ea080eb7f2ace0f714d result = new RL_a351086105893ea080eb7f2ace0f714d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a351086105893ea080eb7f2ace0f714d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(5,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(29,false);
def[3] = new BitArray(17,false);
def[4] = new BitArray(3,false);
def[5] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a5e9a82dc9980e7d5c34d4c26f706ace> NewList() {
return new RL_a351086105893ea080eb7f2ace0f714d();
}


} // RL_a351086105893ea080eb7f2ace0f714d
}

