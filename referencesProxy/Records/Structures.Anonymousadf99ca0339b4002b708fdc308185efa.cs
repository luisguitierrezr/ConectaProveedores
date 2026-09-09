namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (oJz5rZszAkC3CP3DCBhe+g)
///  <code>RC_3554b1e2806a5b827c457cdecc492d4a</code> that represent
/// s <code>ProgressBarOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: ProgressBarOptionalConfigsRecord
public partial struct RC_3554b1e2806a5b827c457cdecc492d4a : ITypedRecord<RC_3554b1e2806a5b827c457cdecc492d4a> {
internal static readonly GlobalObjectKey IdProgressBarOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4rFUNWqAglt8RXzezEktSg");

public ST_8391f9d0c6b78f74493c47987669deecStructure ssSTProgressBarOptionalConfigs;


public static implicit operator ST_8391f9d0c6b78f74493c47987669deecStructure( RC_3554b1e2806a5b827c457cdecc492d4a r) {
return r.ssSTProgressBarOptionalConfigs;
}

public static implicit operator RC_3554b1e2806a5b827c457cdecc492d4a (ST_8391f9d0c6b78f74493c47987669deecStructure r) {
RC_3554b1e2806a5b827c457cdecc492d4a res = new RC_3554b1e2806a5b827c457cdecc492d4a ();
res.ssSTProgressBarOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3554b1e2806a5b827c457cdecc492d4a() {
OptimizedAttributes = null;
ssSTProgressBarOptionalConfigs = new ST_8391f9d0c6b78f74493c47987669deecStructure();
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
    ssSTProgressBarOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTProgressBarOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_3554b1e2806a5b827c457cdecc492d4a r) {
this = r;
}


public static bool operator == (RC_3554b1e2806a5b827c457cdecc492d4a a, RC_3554b1e2806a5b827c457cdecc492d4a b) {
if (a.ssSTProgressBarOptionalConfigs != b.ssSTProgressBarOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_3554b1e2806a5b827c457cdecc492d4a a, RC_3554b1e2806a5b827c457cdecc492d4a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3554b1e2806a5b827c457cdecc492d4a)) return false;
return (this == (RC_3554b1e2806a5b827c457cdecc492d4a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTProgressBarOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTProgressBarOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTProgressBarOptionalConfigs.InternalRecursiveSave();
}


public RC_3554b1e2806a5b827c457cdecc492d4a Duplicate() {
RC_3554b1e2806a5b827c457cdecc492d4a t;
t.ssSTProgressBarOptionalConfigs = (ST_8391f9d0c6b78f74493c47987669deecStructure)this.ssSTProgressBarOptionalConfigs.Duplicate();
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
if (head == "progressbaroptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProgressBarOptionalConfigs")) variable.Value = ssSTProgressBarOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("progressbaroptionalconfigs");
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
if (key == IdProgressBarOptionalConfigs) {
return ssSTProgressBarOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProgressBarOptionalConfigs.Key.AsGuid) {
return ssSTProgressBarOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTProgressBarOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdProgressBarOptionalConfigs));
}
} // RC_3554b1e2806a5b827c457cdecc492d4a
/// <summary>
/// RecordList type <code>ProgressBarOptionalConfigsRecordList</code> that represents a record list of
///  <code>ProgressBarOptionalConfigs</code>
/// </summary>
public partial class RL_9c28fba2ad5d9bbe6b5a769d4094590b : GenericRecordList<RC_3554b1e2806a5b827c457cdecc492d4a>, IEnumerable, IEnumerator {

protected override RC_3554b1e2806a5b827c457cdecc492d4a GetElementDefaultValue() {
return new RC_3554b1e2806a5b827c457cdecc492d4a();
}

public T[] ToArray<T>(Func<RC_3554b1e2806a5b827c457cdecc492d4a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9c28fba2ad5d9bbe6b5a769d4094590b recordList, Func<RC_3554b1e2806a5b827c457cdecc492d4a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9c28fba2ad5d9bbe6b5a769d4094590b(RC_3554b1e2806a5b827c457cdecc492d4a[] array) {
  RL_9c28fba2ad5d9bbe6b5a769d4094590b result = new RL_9c28fba2ad5d9bbe6b5a769d4094590b();
result.InnerFromArray(array);
    return result;
}

public static RL_9c28fba2ad5d9bbe6b5a769d4094590b ToList<T>(T[] array, Func <T, RC_3554b1e2806a5b827c457cdecc492d4a> converter) {
  RL_9c28fba2ad5d9bbe6b5a769d4094590b result = new RL_9c28fba2ad5d9bbe6b5a769d4094590b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9c28fba2ad5d9bbe6b5a769d4094590b FromRestList<T>(RestList<T> restList, Func <T, RC_3554b1e2806a5b827c457cdecc492d4a> converter) {
  RL_9c28fba2ad5d9bbe6b5a769d4094590b result = new RL_9c28fba2ad5d9bbe6b5a769d4094590b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9c28fba2ad5d9bbe6b5a769d4094590b() : base() {
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
protected override OSList<RC_3554b1e2806a5b827c457cdecc492d4a> NewList() {
return new RL_9c28fba2ad5d9bbe6b5a769d4094590b();
}


} // RL_9c28fba2ad5d9bbe6b5a769d4094590b
}

