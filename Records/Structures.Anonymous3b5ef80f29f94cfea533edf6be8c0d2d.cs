namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (D_heO_kp_kylM+32vowNLQ)
///  <code>RC_3755be769accfaea24be428bb1876997</code> that represents <code>ValueItem3Record</code
/// > <p>Description: </p>
/// </summary>
// Name: ValueItem3Record
public partial struct RC_3755be769accfaea24be428bb1876997 : ITypedRecord<RC_3755be769accfaea24be428bb1876997> {
internal static readonly GlobalObjectKey IdValueItem3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dr5VN8ya6vokvkKLsYdplw");

public ST_7103e60d503e9a31fa1ef77b9f0699a9Structure ssSTValueItem3;


public static implicit operator ST_7103e60d503e9a31fa1ef77b9f0699a9Structure( RC_3755be769accfaea24be428bb1876997 r) {
return r.ssSTValueItem3;
}

public static implicit operator RC_3755be769accfaea24be428bb1876997 (ST_7103e60d503e9a31fa1ef77b9f0699a9Structure r) {
RC_3755be769accfaea24be428bb1876997 res = new RC_3755be769accfaea24be428bb1876997 ();
res.ssSTValueItem3 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3755be769accfaea24be428bb1876997() {
OptimizedAttributes = null;
ssSTValueItem3 = new ST_7103e60d503e9a31fa1ef77b9f0699a9Structure();
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
    ssSTValueItem3.OptimizedAttributes = value[0];
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
ssSTValueItem3.Read( r, ref index);
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
public void ReadIM(RC_3755be769accfaea24be428bb1876997 r) {
this = r;
}


public static bool operator == (RC_3755be769accfaea24be428bb1876997 a, RC_3755be769accfaea24be428bb1876997 b) {
if (a.ssSTValueItem3 != b.ssSTValueItem3) return false;
return true;
}

public static bool operator != (RC_3755be769accfaea24be428bb1876997 a, RC_3755be769accfaea24be428bb1876997 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3755be769accfaea24be428bb1876997)) return false;
return (this == (RC_3755be769accfaea24be428bb1876997)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTValueItem3.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTValueItem3.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTValueItem3.InternalRecursiveSave();
}


public RC_3755be769accfaea24be428bb1876997 Duplicate() {
RC_3755be769accfaea24be428bb1876997 t;
t.ssSTValueItem3 = (ST_7103e60d503e9a31fa1ef77b9f0699a9Structure)this.ssSTValueItem3.Duplicate();
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
if (head == "valueitem3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValueItem3")) variable.Value = ssSTValueItem3; else variable.Optimized = true;
variable.SetFieldName("valueitem3");
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
if (key == IdValueItem3) {
return ssSTValueItem3;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValueItem3.Key.AsGuid) {
return ssSTValueItem3;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTValueItem3.FillFromOther((IRecord) other.AttributeGet(IdValueItem3));
}
} // RC_3755be769accfaea24be428bb1876997
/// <summary>
/// RecordList type <code>ValueItem3RecordList</code> that represents a record list of
///  <code>ValueItem3</code>
/// </summary>
public partial class RL_0c660f2f282439d26339ecf81c609f86 : GenericRecordList<RC_3755be769accfaea24be428bb1876997>, IEnumerable, IEnumerator {

protected override RC_3755be769accfaea24be428bb1876997 GetElementDefaultValue() {
return new RC_3755be769accfaea24be428bb1876997();
}

public T[] ToArray<T>(Func<RC_3755be769accfaea24be428bb1876997, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0c660f2f282439d26339ecf81c609f86 recordList, Func<RC_3755be769accfaea24be428bb1876997, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0c660f2f282439d26339ecf81c609f86(RC_3755be769accfaea24be428bb1876997[] array) {
  RL_0c660f2f282439d26339ecf81c609f86 result = new RL_0c660f2f282439d26339ecf81c609f86();
result.InnerFromArray(array);
    return result;
}

public static RL_0c660f2f282439d26339ecf81c609f86 ToList<T>(T[] array, Func <T, RC_3755be769accfaea24be428bb1876997> converter) {
  RL_0c660f2f282439d26339ecf81c609f86 result = new RL_0c660f2f282439d26339ecf81c609f86();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0c660f2f282439d26339ecf81c609f86 FromRestList<T>(RestList<T> restList, Func <T, RC_3755be769accfaea24be428bb1876997> converter) {
  RL_0c660f2f282439d26339ecf81c609f86 result = new RL_0c660f2f282439d26339ecf81c609f86();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0c660f2f282439d26339ecf81c609f86() : base() {
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
protected override OSList<RC_3755be769accfaea24be428bb1876997> NewList() {
return new RL_0c660f2f282439d26339ecf81c609f86();
}


} // RL_0c660f2f282439d26339ecf81c609f86
}

