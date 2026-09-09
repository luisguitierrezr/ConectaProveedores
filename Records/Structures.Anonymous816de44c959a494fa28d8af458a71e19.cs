namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (TORtgZqVT0mijYr0WKceGQ)
///  <code>RC_e71ee504a150cc1126ba54fe808d49c0</code> that represents <code>users2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: users2Record
public partial struct RC_e71ee504a150cc1126ba54fe808d49c0 : ITypedRecord<RC_e71ee504a150cc1126ba54fe808d49c0> {
internal static readonly GlobalObjectKey Idusers2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BOUe51ChEcwmulT+gI1JwA");

public ST_06cbd1286b150e2e79c91e9d1ed3d811Structure ssSTusers2;


public static implicit operator ST_06cbd1286b150e2e79c91e9d1ed3d811Structure( RC_e71ee504a150cc1126ba54fe808d49c0 r) {
return r.ssSTusers2;
}

public static implicit operator RC_e71ee504a150cc1126ba54fe808d49c0 (ST_06cbd1286b150e2e79c91e9d1ed3d811Structure r) {
RC_e71ee504a150cc1126ba54fe808d49c0 res = new RC_e71ee504a150cc1126ba54fe808d49c0 ();
res.ssSTusers2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e71ee504a150cc1126ba54fe808d49c0() {
OptimizedAttributes = null;
ssSTusers2 = new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure();
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
    ssSTusers2.OptimizedAttributes = value[0];
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
ssSTusers2.Read( r, ref index);
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
public void ReadIM(RC_e71ee504a150cc1126ba54fe808d49c0 r) {
this = r;
}


public static bool operator == (RC_e71ee504a150cc1126ba54fe808d49c0 a, RC_e71ee504a150cc1126ba54fe808d49c0 b) {
if (a.ssSTusers2 != b.ssSTusers2) return false;
return true;
}

public static bool operator != (RC_e71ee504a150cc1126ba54fe808d49c0 a, RC_e71ee504a150cc1126ba54fe808d49c0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e71ee504a150cc1126ba54fe808d49c0)) return false;
return (this == (RC_e71ee504a150cc1126ba54fe808d49c0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTusers2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTusers2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTusers2.InternalRecursiveSave();
}


public RC_e71ee504a150cc1126ba54fe808d49c0 Duplicate() {
RC_e71ee504a150cc1126ba54fe808d49c0 t;
t.ssSTusers2 = (ST_06cbd1286b150e2e79c91e9d1ed3d811Structure)this.ssSTusers2.Duplicate();
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
if (head == "users2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".users2")) variable.Value = ssSTusers2; else variable.Optimized = true;
variable.SetFieldName("users2");
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
if (key == Idusers2) {
return ssSTusers2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idusers2.Key.AsGuid) {
return ssSTusers2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTusers2.FillFromOther((IRecord) other.AttributeGet(Idusers2));
}
} // RC_e71ee504a150cc1126ba54fe808d49c0
/// <summary>
/// RecordList type <code>users2RecordList</code> that represents a record list of <code>users2</code>
/// </summary>
public partial class RL_29a54b46cba895c32f341130ed883c72 : GenericRecordList<RC_e71ee504a150cc1126ba54fe808d49c0>, IEnumerable, IEnumerator {

protected override RC_e71ee504a150cc1126ba54fe808d49c0 GetElementDefaultValue() {
return new RC_e71ee504a150cc1126ba54fe808d49c0();
}

public T[] ToArray<T>(Func<RC_e71ee504a150cc1126ba54fe808d49c0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_29a54b46cba895c32f341130ed883c72 recordList, Func<RC_e71ee504a150cc1126ba54fe808d49c0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_29a54b46cba895c32f341130ed883c72(RC_e71ee504a150cc1126ba54fe808d49c0[] array) {
  RL_29a54b46cba895c32f341130ed883c72 result = new RL_29a54b46cba895c32f341130ed883c72();
result.InnerFromArray(array);
    return result;
}

public static RL_29a54b46cba895c32f341130ed883c72 ToList<T>(T[] array, Func <T, RC_e71ee504a150cc1126ba54fe808d49c0> converter) {
  RL_29a54b46cba895c32f341130ed883c72 result = new RL_29a54b46cba895c32f341130ed883c72();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_29a54b46cba895c32f341130ed883c72 FromRestList<T>(RestList<T> restList, Func <T, RC_e71ee504a150cc1126ba54fe808d49c0> converter) {
  RL_29a54b46cba895c32f341130ed883c72 result = new RL_29a54b46cba895c32f341130ed883c72();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_29a54b46cba895c32f341130ed883c72() : base() {
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
protected override OSList<RC_e71ee504a150cc1126ba54fe808d49c0> NewList() {
return new RL_29a54b46cba895c32f341130ed883c72();
}


} // RL_29a54b46cba895c32f341130ed883c72
}

