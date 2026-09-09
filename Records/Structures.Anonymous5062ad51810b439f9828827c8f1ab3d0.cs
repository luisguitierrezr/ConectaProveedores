namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Ua1iUAuBn0OYKIJ8jxqz0A)
///  <code>RC_af9a716157092fb65ec15387ef146a90</code> that represent
/// s <code>User_CreatedUser_UpdatedOrderMainRecord</code> <p>Description: </p>
/// </summary>
// Name: User_CreatedUser_UpdatedOrderMainRecord
public partial struct RC_af9a716157092fb65ec15387ef146a90 : ITypedRecord<RC_af9a716157092fb65ec15387ef146a90> {
internal static readonly GlobalObjectKey IdUser_Created = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*YSDVOOt3vO23fm93lmQ9cg");
internal static readonly GlobalObjectKey IdUser_Updated = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kR9oLTPk4SneMmXwqt3RQA");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public ENUserEntityRecord ssENUser_Created;

public ENUserEntityRecord ssENUser_Updated;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_af9a716157092fb65ec15387ef146a90() {
OptimizedAttributes = null;
ssENUser_Created = new ENUserEntityRecord();
ssENUser_Updated = new ENUserEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser_Created.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Updated.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser_Created.OptimizedAttributes = value[0];
    ssENUser_Updated.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser_Created.OptimizedAttributes;
    all[1] = ssENUser_Updated.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser_Created.Read( r, ref index);
ssENUser_Updated.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_af9a716157092fb65ec15387ef146a90 r) {
this = r;
}


public static bool operator == (RC_af9a716157092fb65ec15387ef146a90 a, RC_af9a716157092fb65ec15387ef146a90 b) {
if (a.ssENUser_Created != b.ssENUser_Created) return false;
if (a.ssENUser_Updated != b.ssENUser_Updated) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_af9a716157092fb65ec15387ef146a90 a, RC_af9a716157092fb65ec15387ef146a90 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_af9a716157092fb65ec15387ef146a90)) return false;
return (this == (RC_af9a716157092fb65ec15387ef146a90)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser_Created.GetHashCode()
 ^ ssENUser_Updated.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser_Created.RecursiveReset();
ssENUser_Updated.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser_Created.InternalRecursiveSave();
ssENUser_Updated.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_af9a716157092fb65ec15387ef146a90 Duplicate() {
RC_af9a716157092fb65ec15387ef146a90 t;
t.ssENUser_Created = (ENUserEntityRecord)this.ssENUser_Created.Duplicate();
t.ssENUser_Updated = (ENUserEntityRecord)this.ssENUser_Updated.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "user_created") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Created")) variable.Value = ssENUser_Created; else variable.Optimized = true;
variable.SetFieldName("user_created");
} else if (head == "user_updated") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Updated")) variable.Value = ssENUser_Updated; else variable.Optimized = true;
variable.SetFieldName("user_updated");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdUser_Created) {
return ssENUser_Created;
}
if (key == IdUser_Updated) {
return ssENUser_Updated;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser_Created.Key.AsGuid) {
return ssENUser_Created;
}
if (attributeKey == IdUser_Updated.Key.AsGuid) {
return ssENUser_Updated;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser_Created.FillFromOther((IRecord) other.AttributeGet(IdUser_Created));
ssENUser_Updated.FillFromOther((IRecord) other.AttributeGet(IdUser_Updated));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_af9a716157092fb65ec15387ef146a90
/// <summary>
/// RecordList type <code>User_CreatedUser_UpdatedOrderMainRecordList</code> that represents a record
///  list of <code>User, User, OrderMain</code>
/// </summary>
public partial class RL_b167cbaf897de91a9e04d193862b7c81 : GenericRecordList<RC_af9a716157092fb65ec15387ef146a90>, IEnumerable, IEnumerator {

protected override RC_af9a716157092fb65ec15387ef146a90 GetElementDefaultValue() {
return new RC_af9a716157092fb65ec15387ef146a90();
}

public T[] ToArray<T>(Func<RC_af9a716157092fb65ec15387ef146a90, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b167cbaf897de91a9e04d193862b7c81 recordList, Func<RC_af9a716157092fb65ec15387ef146a90, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b167cbaf897de91a9e04d193862b7c81(RC_af9a716157092fb65ec15387ef146a90[] array) {
  RL_b167cbaf897de91a9e04d193862b7c81 result = new RL_b167cbaf897de91a9e04d193862b7c81();
result.InnerFromArray(array);
    return result;
}

public static RL_b167cbaf897de91a9e04d193862b7c81 ToList<T>(T[] array, Func <T, RC_af9a716157092fb65ec15387ef146a90> converter) {
  RL_b167cbaf897de91a9e04d193862b7c81 result = new RL_b167cbaf897de91a9e04d193862b7c81();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b167cbaf897de91a9e04d193862b7c81 FromRestList<T>(RestList<T> restList, Func <T, RC_af9a716157092fb65ec15387ef146a90> converter) {
  RL_b167cbaf897de91a9e04d193862b7c81 result = new RL_b167cbaf897de91a9e04d193862b7c81();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b167cbaf897de91a9e04d193862b7c81() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_af9a716157092fb65ec15387ef146a90> NewList() {
return new RL_b167cbaf897de91a9e04d193862b7c81();
}


} // RL_b167cbaf897de91a9e04d193862b7c81
}

