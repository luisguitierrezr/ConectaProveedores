namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (5zZmToGhRU+Rqyyz3cFFxw)
///  <code>RC_bddd91a3bdb44e007c54b330deac93eb</code> that represent
/// s <code>UserOrderApprovalOrderMainOrderApprovalLevelUserExtensionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserOrderApprovalOrderMainOrderApprovalLevelUserExtensionRecord
public partial struct RC_bddd91a3bdb44e007c54b330deac93eb : ITypedRecord<RC_bddd91a3bdb44e007c54b330deac93eb> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");

public ENUserEntityRecord ssENUser;

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;


public BitArray OptimizedAttributes;

public RC_bddd91a3bdb44e007c54b330deac93eb() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(29,false);
    all[3] = new BitArray(17,false);
    all[4] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENOrderApproval.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssENOrderApprovalLevel.OptimizedAttributes = value[3];
    ssENUserExtension.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENOrderApproval.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = ssENOrderApprovalLevel.OptimizedAttributes;
    all[4] = ssENUserExtension.OptimizedAttributes;
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
ssENOrderApproval.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
ssENUserExtension.Read( r, ref index);
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
public void ReadIM(RC_bddd91a3bdb44e007c54b330deac93eb r) {
this = r;
}


public static bool operator == (RC_bddd91a3bdb44e007c54b330deac93eb a, RC_bddd91a3bdb44e007c54b330deac93eb b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
return true;
}

public static bool operator != (RC_bddd91a3bdb44e007c54b330deac93eb a, RC_bddd91a3bdb44e007c54b330deac93eb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bddd91a3bdb44e007c54b330deac93eb)) return false;
return (this == (RC_bddd91a3bdb44e007c54b330deac93eb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENOrderApproval.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
ssENUserExtension.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENOrderApproval.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
}


public RC_bddd91a3bdb44e007c54b330deac93eb Duplicate() {
RC_bddd91a3bdb44e007c54b330deac93eb t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
t.ssENUserExtension = (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)this.ssENUserExtension.Duplicate();
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
}
} // RC_bddd91a3bdb44e007c54b330deac93eb
/// <summary>
/// RecordList type <code>UserOrderApprovalOrderMainOrderApprovalLevelUserExtensionRecordList</code>
///  that represents a record list of <code>User, OrderApproval, OrderMain, OrderApprovalLevel
/// , UserExtension</code>
/// </summary>
public partial class RL_6d716f51b4f729d7294bc619c2474a13 : GenericRecordList<RC_bddd91a3bdb44e007c54b330deac93eb>, IEnumerable, IEnumerator {

protected override RC_bddd91a3bdb44e007c54b330deac93eb GetElementDefaultValue() {
return new RC_bddd91a3bdb44e007c54b330deac93eb();
}

public T[] ToArray<T>(Func<RC_bddd91a3bdb44e007c54b330deac93eb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6d716f51b4f729d7294bc619c2474a13 recordList, Func<RC_bddd91a3bdb44e007c54b330deac93eb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6d716f51b4f729d7294bc619c2474a13(RC_bddd91a3bdb44e007c54b330deac93eb[] array) {
  RL_6d716f51b4f729d7294bc619c2474a13 result = new RL_6d716f51b4f729d7294bc619c2474a13();
result.InnerFromArray(array);
    return result;
}

public static RL_6d716f51b4f729d7294bc619c2474a13 ToList<T>(T[] array, Func <T, RC_bddd91a3bdb44e007c54b330deac93eb> converter) {
  RL_6d716f51b4f729d7294bc619c2474a13 result = new RL_6d716f51b4f729d7294bc619c2474a13();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6d716f51b4f729d7294bc619c2474a13 FromRestList<T>(RestList<T> restList, Func <T, RC_bddd91a3bdb44e007c54b330deac93eb> converter) {
  RL_6d716f51b4f729d7294bc619c2474a13 result = new RL_6d716f51b4f729d7294bc619c2474a13();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6d716f51b4f729d7294bc619c2474a13() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(5,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(29,false);
def[3] = new BitArray(17,false);
def[4] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bddd91a3bdb44e007c54b330deac93eb> NewList() {
return new RL_6d716f51b4f729d7294bc619c2474a13();
}


} // RL_6d716f51b4f729d7294bc619c2474a13
}

