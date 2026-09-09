namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (j3_QKTsS4Uy2Fu00ts9kFw)
///  <code>RC_e7cd27f178bb008051b405d4529062d2</code> that represents <code>PI_HEADER_EMRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_HEADER_EMRecord
public partial struct RC_e7cd27f178bb008051b405d4529062d2 : ITypedRecord<RC_e7cd27f178bb008051b405d4529062d2> {
internal static readonly GlobalObjectKey IdPI_HEADER_EM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8SfN57t4gABRtAXUUpBi0g");

public ST_1186519ca5bb238ab9fc7126d4696469Structure ssSTPI_HEADER_EM;


public static implicit operator ST_1186519ca5bb238ab9fc7126d4696469Structure( RC_e7cd27f178bb008051b405d4529062d2 r) {
return r.ssSTPI_HEADER_EM;
}

public static implicit operator RC_e7cd27f178bb008051b405d4529062d2 (ST_1186519ca5bb238ab9fc7126d4696469Structure r) {
RC_e7cd27f178bb008051b405d4529062d2 res = new RC_e7cd27f178bb008051b405d4529062d2 ();
res.ssSTPI_HEADER_EM = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e7cd27f178bb008051b405d4529062d2() {
OptimizedAttributes = null;
ssSTPI_HEADER_EM = new ST_1186519ca5bb238ab9fc7126d4696469Structure();
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
    ssSTPI_HEADER_EM.OptimizedAttributes = value[0];
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
ssSTPI_HEADER_EM.Read( r, ref index);
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
public void ReadIM(RC_e7cd27f178bb008051b405d4529062d2 r) {
this = r;
}


public static bool operator == (RC_e7cd27f178bb008051b405d4529062d2 a, RC_e7cd27f178bb008051b405d4529062d2 b) {
if (a.ssSTPI_HEADER_EM != b.ssSTPI_HEADER_EM) return false;
return true;
}

public static bool operator != (RC_e7cd27f178bb008051b405d4529062d2 a, RC_e7cd27f178bb008051b405d4529062d2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e7cd27f178bb008051b405d4529062d2)) return false;
return (this == (RC_e7cd27f178bb008051b405d4529062d2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_HEADER_EM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_HEADER_EM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_HEADER_EM.InternalRecursiveSave();
}


public RC_e7cd27f178bb008051b405d4529062d2 Duplicate() {
RC_e7cd27f178bb008051b405d4529062d2 t;
t.ssSTPI_HEADER_EM = (ST_1186519ca5bb238ab9fc7126d4696469Structure)this.ssSTPI_HEADER_EM.Duplicate();
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
if (head == "pi_header_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER_EM")) variable.Value = ssSTPI_HEADER_EM; else variable.Optimized = true;
variable.SetFieldName("pi_header_em");
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
if (key == IdPI_HEADER_EM) {
return ssSTPI_HEADER_EM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER_EM.Key.AsGuid) {
return ssSTPI_HEADER_EM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_HEADER_EM.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER_EM));
}
} // RC_e7cd27f178bb008051b405d4529062d2
/// <summary>
/// RecordList type <code>PI_HEADER_EMRecordList</code> that represents a record list of
///  <code>PI_HEADER_EM</code>
/// </summary>
public partial class RL_b02706de3407ddadeaf90cf122ab9f33 : GenericRecordList<RC_e7cd27f178bb008051b405d4529062d2>, IEnumerable, IEnumerator {

protected override RC_e7cd27f178bb008051b405d4529062d2 GetElementDefaultValue() {
return new RC_e7cd27f178bb008051b405d4529062d2();
}

public T[] ToArray<T>(Func<RC_e7cd27f178bb008051b405d4529062d2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b02706de3407ddadeaf90cf122ab9f33 recordList, Func<RC_e7cd27f178bb008051b405d4529062d2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b02706de3407ddadeaf90cf122ab9f33(RC_e7cd27f178bb008051b405d4529062d2[] array) {
  RL_b02706de3407ddadeaf90cf122ab9f33 result = new RL_b02706de3407ddadeaf90cf122ab9f33();
result.InnerFromArray(array);
    return result;
}

public static RL_b02706de3407ddadeaf90cf122ab9f33 ToList<T>(T[] array, Func <T, RC_e7cd27f178bb008051b405d4529062d2> converter) {
  RL_b02706de3407ddadeaf90cf122ab9f33 result = new RL_b02706de3407ddadeaf90cf122ab9f33();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b02706de3407ddadeaf90cf122ab9f33 FromRestList<T>(RestList<T> restList, Func <T, RC_e7cd27f178bb008051b405d4529062d2> converter) {
  RL_b02706de3407ddadeaf90cf122ab9f33 result = new RL_b02706de3407ddadeaf90cf122ab9f33();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b02706de3407ddadeaf90cf122ab9f33() : base() {
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
protected override OSList<RC_e7cd27f178bb008051b405d4529062d2> NewList() {
return new RL_b02706de3407ddadeaf90cf122ab9f33();
}


} // RL_b02706de3407ddadeaf90cf122ab9f33
}

