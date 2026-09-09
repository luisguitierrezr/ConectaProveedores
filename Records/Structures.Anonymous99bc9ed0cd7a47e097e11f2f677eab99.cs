namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (0J68mXrN4EeX4R8vZ36rmQ)
///  <code>RC_c6d76d2db9750f8821329794e48c8217</code> that represents <code>StepRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: StepRecord
public partial struct RC_c6d76d2db9750f8821329794e48c8217 : ITypedRecord<RC_c6d76d2db9750f8821329794e48c8217> {
internal static readonly GlobalObjectKey IdStep = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LW3XxnW5iA8hMpeU5IyCFw");

public ST_d1e6f35068707165b6684293e397ea3bStructure ssSTStep;


public static implicit operator ST_d1e6f35068707165b6684293e397ea3bStructure( RC_c6d76d2db9750f8821329794e48c8217 r) {
return r.ssSTStep;
}

public static implicit operator RC_c6d76d2db9750f8821329794e48c8217 (ST_d1e6f35068707165b6684293e397ea3bStructure r) {
RC_c6d76d2db9750f8821329794e48c8217 res = new RC_c6d76d2db9750f8821329794e48c8217 ();
res.ssSTStep = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c6d76d2db9750f8821329794e48c8217() {
OptimizedAttributes = null;
ssSTStep = new ST_d1e6f35068707165b6684293e397ea3bStructure();
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
    ssSTStep.OptimizedAttributes = value[0];
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
ssSTStep.Read( r, ref index);
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
public void ReadIM(RC_c6d76d2db9750f8821329794e48c8217 r) {
this = r;
}


public static bool operator == (RC_c6d76d2db9750f8821329794e48c8217 a, RC_c6d76d2db9750f8821329794e48c8217 b) {
if (a.ssSTStep != b.ssSTStep) return false;
return true;
}

public static bool operator != (RC_c6d76d2db9750f8821329794e48c8217 a, RC_c6d76d2db9750f8821329794e48c8217 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c6d76d2db9750f8821329794e48c8217)) return false;
return (this == (RC_c6d76d2db9750f8821329794e48c8217)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTStep.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTStep.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTStep.InternalRecursiveSave();
}


public RC_c6d76d2db9750f8821329794e48c8217 Duplicate() {
RC_c6d76d2db9750f8821329794e48c8217 t;
t.ssSTStep = (ST_d1e6f35068707165b6684293e397ea3bStructure)this.ssSTStep.Duplicate();
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
if (head == "step") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Step")) variable.Value = ssSTStep; else variable.Optimized = true;
variable.SetFieldName("step");
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
if (key == IdStep) {
return ssSTStep;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStep.Key.AsGuid) {
return ssSTStep;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTStep.FillFromOther((IRecord) other.AttributeGet(IdStep));
}
} // RC_c6d76d2db9750f8821329794e48c8217
/// <summary>
/// RecordList type <code>StepRecordList</code> that represents a record list of <code>Step</code>
/// </summary>
public partial class RL_0cab74dc6baf0091eb419b60961fda0e : GenericRecordList<RC_c6d76d2db9750f8821329794e48c8217>, IEnumerable, IEnumerator {

protected override RC_c6d76d2db9750f8821329794e48c8217 GetElementDefaultValue() {
return new RC_c6d76d2db9750f8821329794e48c8217();
}

public T[] ToArray<T>(Func<RC_c6d76d2db9750f8821329794e48c8217, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0cab74dc6baf0091eb419b60961fda0e recordList, Func<RC_c6d76d2db9750f8821329794e48c8217, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0cab74dc6baf0091eb419b60961fda0e(RC_c6d76d2db9750f8821329794e48c8217[] array) {
  RL_0cab74dc6baf0091eb419b60961fda0e result = new RL_0cab74dc6baf0091eb419b60961fda0e();
result.InnerFromArray(array);
    return result;
}

public static RL_0cab74dc6baf0091eb419b60961fda0e ToList<T>(T[] array, Func <T, RC_c6d76d2db9750f8821329794e48c8217> converter) {
  RL_0cab74dc6baf0091eb419b60961fda0e result = new RL_0cab74dc6baf0091eb419b60961fda0e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0cab74dc6baf0091eb419b60961fda0e FromRestList<T>(RestList<T> restList, Func <T, RC_c6d76d2db9750f8821329794e48c8217> converter) {
  RL_0cab74dc6baf0091eb419b60961fda0e result = new RL_0cab74dc6baf0091eb419b60961fda0e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0cab74dc6baf0091eb419b60961fda0e() : base() {
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
protected override OSList<RC_c6d76d2db9750f8821329794e48c8217> NewList() {
return new RL_0cab74dc6baf0091eb419b60961fda0e();
}


} // RL_0cab74dc6baf0091eb419b60961fda0e
}

