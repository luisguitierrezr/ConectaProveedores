namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Cnz4D0Nfikq8veCTAU74RQ)
///  <code>RC_e5ad8f04c38047441643c6868992c277</code> that represent
/// s <code>NotificationOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: NotificationOptionalConfigsRecord
public partial struct RC_e5ad8f04c38047441643c6868992c277 : ITypedRecord<RC_e5ad8f04c38047441643c6868992c277> {
internal static readonly GlobalObjectKey IdNotificationOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BI+t5YDDREcWQ8aGiZLCdw");

public ST_09173c1b0f41f719b9efd6430c2e737dStructure ssSTNotificationOptionalConfigs;


public static implicit operator ST_09173c1b0f41f719b9efd6430c2e737dStructure( RC_e5ad8f04c38047441643c6868992c277 r) {
return r.ssSTNotificationOptionalConfigs;
}

public static implicit operator RC_e5ad8f04c38047441643c6868992c277 (ST_09173c1b0f41f719b9efd6430c2e737dStructure r) {
RC_e5ad8f04c38047441643c6868992c277 res = new RC_e5ad8f04c38047441643c6868992c277 ();
res.ssSTNotificationOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e5ad8f04c38047441643c6868992c277() {
OptimizedAttributes = null;
ssSTNotificationOptionalConfigs = new ST_09173c1b0f41f719b9efd6430c2e737dStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTNotificationOptionalConfigs.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTNotificationOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_e5ad8f04c38047441643c6868992c277 r) {
this = r;
}


public static bool operator == (RC_e5ad8f04c38047441643c6868992c277 a, RC_e5ad8f04c38047441643c6868992c277 b) {
if (a.ssSTNotificationOptionalConfigs != b.ssSTNotificationOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_e5ad8f04c38047441643c6868992c277 a, RC_e5ad8f04c38047441643c6868992c277 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e5ad8f04c38047441643c6868992c277)) return false;
return (this == (RC_e5ad8f04c38047441643c6868992c277)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTNotificationOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTNotificationOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTNotificationOptionalConfigs.InternalRecursiveSave();
}


public RC_e5ad8f04c38047441643c6868992c277 Duplicate() {
RC_e5ad8f04c38047441643c6868992c277 t;
t.ssSTNotificationOptionalConfigs = (ST_09173c1b0f41f719b9efd6430c2e737dStructure)this.ssSTNotificationOptionalConfigs.Duplicate();
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
if (head == "notificationoptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NotificationOptionalConfigs")) variable.Value = ssSTNotificationOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("notificationoptionalconfigs");
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
if (key == IdNotificationOptionalConfigs) {
return ssSTNotificationOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNotificationOptionalConfigs.Key.AsGuid) {
return ssSTNotificationOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTNotificationOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdNotificationOptionalConfigs));
}
} // RC_e5ad8f04c38047441643c6868992c277
/// <summary>
/// RecordList type <code>NotificationOptionalConfigsRecordList</code> that represents a record list of
///  <code>NotificationOptionalConfigs</code>
/// </summary>
public partial class RL_7d09eb138f7abf181049d020e739a58f : GenericRecordList<RC_e5ad8f04c38047441643c6868992c277>, IEnumerable, IEnumerator {

protected override RC_e5ad8f04c38047441643c6868992c277 GetElementDefaultValue() {
return new RC_e5ad8f04c38047441643c6868992c277();
}

public T[] ToArray<T>(Func<RC_e5ad8f04c38047441643c6868992c277, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7d09eb138f7abf181049d020e739a58f recordList, Func<RC_e5ad8f04c38047441643c6868992c277, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7d09eb138f7abf181049d020e739a58f(RC_e5ad8f04c38047441643c6868992c277[] array) {
  RL_7d09eb138f7abf181049d020e739a58f result = new RL_7d09eb138f7abf181049d020e739a58f();
result.InnerFromArray(array);
    return result;
}

public static RL_7d09eb138f7abf181049d020e739a58f ToList<T>(T[] array, Func <T, RC_e5ad8f04c38047441643c6868992c277> converter) {
  RL_7d09eb138f7abf181049d020e739a58f result = new RL_7d09eb138f7abf181049d020e739a58f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7d09eb138f7abf181049d020e739a58f FromRestList<T>(RestList<T> restList, Func <T, RC_e5ad8f04c38047441643c6868992c277> converter) {
  RL_7d09eb138f7abf181049d020e739a58f result = new RL_7d09eb138f7abf181049d020e739a58f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7d09eb138f7abf181049d020e739a58f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e5ad8f04c38047441643c6868992c277> NewList() {
return new RL_7d09eb138f7abf181049d020e739a58f();
}


} // RL_7d09eb138f7abf181049d020e739a58f
}

