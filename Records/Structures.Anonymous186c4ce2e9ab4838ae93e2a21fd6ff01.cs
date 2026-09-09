namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (4kxsGKvpOEiuk+KiH9b_AQ)
///  <code>RC_4e56da462177bd5a32125e4b7b238f14</code> that represents <code>TO_RESULTADO_InRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TO_RESULTADO_InRecord
public partial struct RC_4e56da462177bd5a32125e4b7b238f14 : ITypedRecord<RC_4e56da462177bd5a32125e4b7b238f14> {
internal static readonly GlobalObjectKey IdTO_RESULTADO_In = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RtpWTnchWr0yEl5LeyOPFA");

public ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure ssSTTO_RESULTADO_In;


public static implicit operator ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure( RC_4e56da462177bd5a32125e4b7b238f14 r) {
return r.ssSTTO_RESULTADO_In;
}

public static implicit operator RC_4e56da462177bd5a32125e4b7b238f14 (ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure r) {
RC_4e56da462177bd5a32125e4b7b238f14 res = new RC_4e56da462177bd5a32125e4b7b238f14 ();
res.ssSTTO_RESULTADO_In = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4e56da462177bd5a32125e4b7b238f14() {
OptimizedAttributes = null;
ssSTTO_RESULTADO_In = new ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure();
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
    ssSTTO_RESULTADO_In.OptimizedAttributes = value[0];
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
ssSTTO_RESULTADO_In.Read( r, ref index);
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
public void ReadIM(RC_4e56da462177bd5a32125e4b7b238f14 r) {
this = r;
}


public static bool operator == (RC_4e56da462177bd5a32125e4b7b238f14 a, RC_4e56da462177bd5a32125e4b7b238f14 b) {
if (a.ssSTTO_RESULTADO_In != b.ssSTTO_RESULTADO_In) return false;
return true;
}

public static bool operator != (RC_4e56da462177bd5a32125e4b7b238f14 a, RC_4e56da462177bd5a32125e4b7b238f14 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4e56da462177bd5a32125e4b7b238f14)) return false;
return (this == (RC_4e56da462177bd5a32125e4b7b238f14)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTO_RESULTADO_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTO_RESULTADO_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTO_RESULTADO_In.InternalRecursiveSave();
}


public RC_4e56da462177bd5a32125e4b7b238f14 Duplicate() {
RC_4e56da462177bd5a32125e4b7b238f14 t;
t.ssSTTO_RESULTADO_In = (ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure)this.ssSTTO_RESULTADO_In.Duplicate();
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
if (head == "to_resultado_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TO_RESULTADO_In")) variable.Value = ssSTTO_RESULTADO_In; else variable.Optimized = true;
variable.SetFieldName("to_resultado_in");
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
if (key == IdTO_RESULTADO_In) {
return ssSTTO_RESULTADO_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTO_RESULTADO_In.Key.AsGuid) {
return ssSTTO_RESULTADO_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTO_RESULTADO_In.FillFromOther((IRecord) other.AttributeGet(IdTO_RESULTADO_In));
}
} // RC_4e56da462177bd5a32125e4b7b238f14
/// <summary>
/// RecordList type <code>TO_RESULTADO_InRecordList</code> that represents a record list of
///  <code>TO_RESULTADO_In</code>
/// </summary>
public partial class RL_9e3a9c4e29b0aa001aa21edf0e49b00f : GenericRecordList<RC_4e56da462177bd5a32125e4b7b238f14>, IEnumerable, IEnumerator {

protected override RC_4e56da462177bd5a32125e4b7b238f14 GetElementDefaultValue() {
return new RC_4e56da462177bd5a32125e4b7b238f14();
}

public T[] ToArray<T>(Func<RC_4e56da462177bd5a32125e4b7b238f14, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9e3a9c4e29b0aa001aa21edf0e49b00f recordList, Func<RC_4e56da462177bd5a32125e4b7b238f14, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9e3a9c4e29b0aa001aa21edf0e49b00f(RC_4e56da462177bd5a32125e4b7b238f14[] array) {
  RL_9e3a9c4e29b0aa001aa21edf0e49b00f result = new RL_9e3a9c4e29b0aa001aa21edf0e49b00f();
result.InnerFromArray(array);
    return result;
}

public static RL_9e3a9c4e29b0aa001aa21edf0e49b00f ToList<T>(T[] array, Func <T, RC_4e56da462177bd5a32125e4b7b238f14> converter) {
  RL_9e3a9c4e29b0aa001aa21edf0e49b00f result = new RL_9e3a9c4e29b0aa001aa21edf0e49b00f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9e3a9c4e29b0aa001aa21edf0e49b00f FromRestList<T>(RestList<T> restList, Func <T, RC_4e56da462177bd5a32125e4b7b238f14> converter) {
  RL_9e3a9c4e29b0aa001aa21edf0e49b00f result = new RL_9e3a9c4e29b0aa001aa21edf0e49b00f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9e3a9c4e29b0aa001aa21edf0e49b00f() : base() {
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
protected override OSList<RC_4e56da462177bd5a32125e4b7b238f14> NewList() {
return new RL_9e3a9c4e29b0aa001aa21edf0e49b00f();
}


} // RL_9e3a9c4e29b0aa001aa21edf0e49b00f
}

