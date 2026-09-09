namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (b3BtwuJJYkyc6phXnsWPtA)
///  <code>RC_f1477873234f7ffa4a835a69241c272d</code> that represent
/// s <code>ValidaCfdResultWrapperRecord</code> <p>Description: </p>
/// </summary>
// Name: ValidaCfdResultWrapperRecord
public partial struct RC_f1477873234f7ffa4a835a69241c272d : ITypedRecord<RC_f1477873234f7ffa4a835a69241c272d> {
internal static readonly GlobalObjectKey IdValidaCfdResultWrapper = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*c3hH8U8j+n9Kg1ppJBwnLQ");

public ST_b861b971a77239711f72752e074dae26Structure ssSTValidaCfdResultWrapper;


public static implicit operator ST_b861b971a77239711f72752e074dae26Structure( RC_f1477873234f7ffa4a835a69241c272d r) {
return r.ssSTValidaCfdResultWrapper;
}

public static implicit operator RC_f1477873234f7ffa4a835a69241c272d (ST_b861b971a77239711f72752e074dae26Structure r) {
RC_f1477873234f7ffa4a835a69241c272d res = new RC_f1477873234f7ffa4a835a69241c272d ();
res.ssSTValidaCfdResultWrapper = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f1477873234f7ffa4a835a69241c272d() {
OptimizedAttributes = null;
ssSTValidaCfdResultWrapper = new ST_b861b971a77239711f72752e074dae26Structure();
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
    ssSTValidaCfdResultWrapper.OptimizedAttributes = value[0];
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
ssSTValidaCfdResultWrapper.Read( r, ref index);
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
public void ReadIM(RC_f1477873234f7ffa4a835a69241c272d r) {
this = r;
}


public static bool operator == (RC_f1477873234f7ffa4a835a69241c272d a, RC_f1477873234f7ffa4a835a69241c272d b) {
if (a.ssSTValidaCfdResultWrapper != b.ssSTValidaCfdResultWrapper) return false;
return true;
}

public static bool operator != (RC_f1477873234f7ffa4a835a69241c272d a, RC_f1477873234f7ffa4a835a69241c272d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f1477873234f7ffa4a835a69241c272d)) return false;
return (this == (RC_f1477873234f7ffa4a835a69241c272d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTValidaCfdResultWrapper.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTValidaCfdResultWrapper.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTValidaCfdResultWrapper.InternalRecursiveSave();
}


public RC_f1477873234f7ffa4a835a69241c272d Duplicate() {
RC_f1477873234f7ffa4a835a69241c272d t;
t.ssSTValidaCfdResultWrapper = (ST_b861b971a77239711f72752e074dae26Structure)this.ssSTValidaCfdResultWrapper.Duplicate();
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
if (head == "validacfdresultwrapper") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValidaCfdResultWrapper")) variable.Value = ssSTValidaCfdResultWrapper; else variable.Optimized = true;
variable.SetFieldName("validacfdresultwrapper");
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
if (key == IdValidaCfdResultWrapper) {
return ssSTValidaCfdResultWrapper;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValidaCfdResultWrapper.Key.AsGuid) {
return ssSTValidaCfdResultWrapper;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTValidaCfdResultWrapper.FillFromOther((IRecord) other.AttributeGet(IdValidaCfdResultWrapper));
}
} // RC_f1477873234f7ffa4a835a69241c272d
/// <summary>
/// RecordList type <code>ValidaCfdResultWrapperRecordList</code> that represents a record list of
///  <code>ValidaCfdResultWrapper</code>
/// </summary>
public partial class RL_b34aa49b3529d5bea3f5036ab99f0d89 : GenericRecordList<RC_f1477873234f7ffa4a835a69241c272d>, IEnumerable, IEnumerator {

protected override RC_f1477873234f7ffa4a835a69241c272d GetElementDefaultValue() {
return new RC_f1477873234f7ffa4a835a69241c272d();
}

public T[] ToArray<T>(Func<RC_f1477873234f7ffa4a835a69241c272d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b34aa49b3529d5bea3f5036ab99f0d89 recordList, Func<RC_f1477873234f7ffa4a835a69241c272d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b34aa49b3529d5bea3f5036ab99f0d89(RC_f1477873234f7ffa4a835a69241c272d[] array) {
  RL_b34aa49b3529d5bea3f5036ab99f0d89 result = new RL_b34aa49b3529d5bea3f5036ab99f0d89();
result.InnerFromArray(array);
    return result;
}

public static RL_b34aa49b3529d5bea3f5036ab99f0d89 ToList<T>(T[] array, Func <T, RC_f1477873234f7ffa4a835a69241c272d> converter) {
  RL_b34aa49b3529d5bea3f5036ab99f0d89 result = new RL_b34aa49b3529d5bea3f5036ab99f0d89();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b34aa49b3529d5bea3f5036ab99f0d89 FromRestList<T>(RestList<T> restList, Func <T, RC_f1477873234f7ffa4a835a69241c272d> converter) {
  RL_b34aa49b3529d5bea3f5036ab99f0d89 result = new RL_b34aa49b3529d5bea3f5036ab99f0d89();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b34aa49b3529d5bea3f5036ab99f0d89() : base() {
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
protected override OSList<RC_f1477873234f7ffa4a835a69241c272d> NewList() {
return new RL_b34aa49b3529d5bea3f5036ab99f0d89();
}


} // RL_b34aa49b3529d5bea3f5036ab99f0d89
}

