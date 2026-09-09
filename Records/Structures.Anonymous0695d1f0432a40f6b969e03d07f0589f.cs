namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (8NGVBipD9kC5aeA9B_BYnw)
///  <code>RC_48f837ac894bfbcf11c3d8c2e6c47c59</code> that represent
/// s <code>UserOrderMainOrderLogsRecord</code> <p>Description: </p>
/// </summary>
// Name: UserOrderMainOrderLogsRecord
public partial struct RC_48f837ac894bfbcf11c3d8c2e6c47c59 : ITypedRecord<RC_48f837ac894bfbcf11c3d8c2e6c47c59> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderLogs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0wqVqgLdSDWNudZTB2cxmQ");

public ENUserEntityRecord ssENUser;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_a8e484428097204171df8a1feecb2534EntityRecord ssENOrderLogs;


public BitArray OptimizedAttributes;

public RC_48f837ac894bfbcf11c3d8c2e6c47c59() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderLogs = new EN_a8e484428097204171df8a1feecb2534EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderLogs.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENOrderLogs.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENOrderLogs.OptimizedAttributes;
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
ssENOrderMain.Read( r, ref index);
ssENOrderLogs.Read( r, ref index);
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
public void ReadIM(RC_48f837ac894bfbcf11c3d8c2e6c47c59 r) {
this = r;
}


public static bool operator == (RC_48f837ac894bfbcf11c3d8c2e6c47c59 a, RC_48f837ac894bfbcf11c3d8c2e6c47c59 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderLogs != b.ssENOrderLogs) return false;
return true;
}

public static bool operator != (RC_48f837ac894bfbcf11c3d8c2e6c47c59 a, RC_48f837ac894bfbcf11c3d8c2e6c47c59 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_48f837ac894bfbcf11c3d8c2e6c47c59)) return false;
return (this == (RC_48f837ac894bfbcf11c3d8c2e6c47c59)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderLogs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderLogs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderLogs.InternalRecursiveSave();
}


public RC_48f837ac894bfbcf11c3d8c2e6c47c59 Duplicate() {
RC_48f837ac894bfbcf11c3d8c2e6c47c59 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderLogs = (EN_a8e484428097204171df8a1feecb2534EntityRecord)this.ssENOrderLogs.Duplicate();
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
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderlogs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderLogs")) variable.Value = ssENOrderLogs; else variable.Optimized = true;
variable.SetFieldName("orderlogs");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderLogs) {
return ssENOrderLogs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderLogs.Key.AsGuid) {
return ssENOrderLogs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderLogs.FillFromOther((IRecord) other.AttributeGet(IdOrderLogs));
}
} // RC_48f837ac894bfbcf11c3d8c2e6c47c59
/// <summary>
/// RecordList type <code>UserOrderMainOrderLogsRecordList</code> that represents a record list of
///  <code>User, OrderMain, OrderLogs</code>
/// </summary>
public partial class RL_09a534c151a8c55dd3e3e1962f18631c : GenericRecordList<RC_48f837ac894bfbcf11c3d8c2e6c47c59>, IEnumerable, IEnumerator {

protected override RC_48f837ac894bfbcf11c3d8c2e6c47c59 GetElementDefaultValue() {
return new RC_48f837ac894bfbcf11c3d8c2e6c47c59();
}

public T[] ToArray<T>(Func<RC_48f837ac894bfbcf11c3d8c2e6c47c59, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_09a534c151a8c55dd3e3e1962f18631c recordList, Func<RC_48f837ac894bfbcf11c3d8c2e6c47c59, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_09a534c151a8c55dd3e3e1962f18631c(RC_48f837ac894bfbcf11c3d8c2e6c47c59[] array) {
  RL_09a534c151a8c55dd3e3e1962f18631c result = new RL_09a534c151a8c55dd3e3e1962f18631c();
result.InnerFromArray(array);
    return result;
}

public static RL_09a534c151a8c55dd3e3e1962f18631c ToList<T>(T[] array, Func <T, RC_48f837ac894bfbcf11c3d8c2e6c47c59> converter) {
  RL_09a534c151a8c55dd3e3e1962f18631c result = new RL_09a534c151a8c55dd3e3e1962f18631c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_09a534c151a8c55dd3e3e1962f18631c FromRestList<T>(RestList<T> restList, Func <T, RC_48f837ac894bfbcf11c3d8c2e6c47c59> converter) {
  RL_09a534c151a8c55dd3e3e1962f18631c result = new RL_09a534c151a8c55dd3e3e1962f18631c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_09a534c151a8c55dd3e3e1962f18631c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_48f837ac894bfbcf11c3d8c2e6c47c59> NewList() {
return new RL_09a534c151a8c55dd3e3e1962f18631c();
}


} // RL_09a534c151a8c55dd3e3e1962f18631c
}

