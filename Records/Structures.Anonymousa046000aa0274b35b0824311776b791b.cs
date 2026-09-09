namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (CgBGoCegNUuwgkMRd2t5Gw)
///  <code>RC_e4b3818aab18afe673c72bba366c601e</code> that represents <code>APIOutput2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: APIOutput2Record
public partial struct RC_e4b3818aab18afe673c72bba366c601e : ITypedRecord<RC_e4b3818aab18afe673c72bba366c601e> {
internal static readonly GlobalObjectKey IdAPIOutput2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ioGz5Bir5q9zxyu6NmxgHg");

public ST_8509a484f6b6eac99c83feddd35d5004Structure ssSTAPIOutput2;


public static implicit operator ST_8509a484f6b6eac99c83feddd35d5004Structure( RC_e4b3818aab18afe673c72bba366c601e r) {
return r.ssSTAPIOutput2;
}

public static implicit operator RC_e4b3818aab18afe673c72bba366c601e (ST_8509a484f6b6eac99c83feddd35d5004Structure r) {
RC_e4b3818aab18afe673c72bba366c601e res = new RC_e4b3818aab18afe673c72bba366c601e ();
res.ssSTAPIOutput2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e4b3818aab18afe673c72bba366c601e() {
OptimizedAttributes = null;
ssSTAPIOutput2 = new ST_8509a484f6b6eac99c83feddd35d5004Structure();
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
    ssSTAPIOutput2.OptimizedAttributes = value[0];
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
ssSTAPIOutput2.Read( r, ref index);
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
public void ReadIM(RC_e4b3818aab18afe673c72bba366c601e r) {
this = r;
}


public static bool operator == (RC_e4b3818aab18afe673c72bba366c601e a, RC_e4b3818aab18afe673c72bba366c601e b) {
if (a.ssSTAPIOutput2 != b.ssSTAPIOutput2) return false;
return true;
}

public static bool operator != (RC_e4b3818aab18afe673c72bba366c601e a, RC_e4b3818aab18afe673c72bba366c601e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e4b3818aab18afe673c72bba366c601e)) return false;
return (this == (RC_e4b3818aab18afe673c72bba366c601e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAPIOutput2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAPIOutput2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAPIOutput2.InternalRecursiveSave();
}


public RC_e4b3818aab18afe673c72bba366c601e Duplicate() {
RC_e4b3818aab18afe673c72bba366c601e t;
t.ssSTAPIOutput2 = (ST_8509a484f6b6eac99c83feddd35d5004Structure)this.ssSTAPIOutput2.Duplicate();
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
if (head == "apioutput2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".APIOutput2")) variable.Value = ssSTAPIOutput2; else variable.Optimized = true;
variable.SetFieldName("apioutput2");
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
if (key == IdAPIOutput2) {
return ssSTAPIOutput2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAPIOutput2.Key.AsGuid) {
return ssSTAPIOutput2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAPIOutput2.FillFromOther((IRecord) other.AttributeGet(IdAPIOutput2));
}
} // RC_e4b3818aab18afe673c72bba366c601e
/// <summary>
/// RecordList type <code>APIOutput2RecordList</code> that represents a record list of
///  <code>APIOutput2</code>
/// </summary>
public partial class RL_c8d28bf6dd153eaa497880acdf281709 : GenericRecordList<RC_e4b3818aab18afe673c72bba366c601e>, IEnumerable, IEnumerator {

protected override RC_e4b3818aab18afe673c72bba366c601e GetElementDefaultValue() {
return new RC_e4b3818aab18afe673c72bba366c601e();
}

public T[] ToArray<T>(Func<RC_e4b3818aab18afe673c72bba366c601e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c8d28bf6dd153eaa497880acdf281709 recordList, Func<RC_e4b3818aab18afe673c72bba366c601e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c8d28bf6dd153eaa497880acdf281709(RC_e4b3818aab18afe673c72bba366c601e[] array) {
  RL_c8d28bf6dd153eaa497880acdf281709 result = new RL_c8d28bf6dd153eaa497880acdf281709();
result.InnerFromArray(array);
    return result;
}

public static RL_c8d28bf6dd153eaa497880acdf281709 ToList<T>(T[] array, Func <T, RC_e4b3818aab18afe673c72bba366c601e> converter) {
  RL_c8d28bf6dd153eaa497880acdf281709 result = new RL_c8d28bf6dd153eaa497880acdf281709();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c8d28bf6dd153eaa497880acdf281709 FromRestList<T>(RestList<T> restList, Func <T, RC_e4b3818aab18afe673c72bba366c601e> converter) {
  RL_c8d28bf6dd153eaa497880acdf281709 result = new RL_c8d28bf6dd153eaa497880acdf281709();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c8d28bf6dd153eaa497880acdf281709() : base() {
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
protected override OSList<RC_e4b3818aab18afe673c72bba366c601e> NewList() {
return new RL_c8d28bf6dd153eaa497880acdf281709();
}


} // RL_c8d28bf6dd153eaa497880acdf281709
}

