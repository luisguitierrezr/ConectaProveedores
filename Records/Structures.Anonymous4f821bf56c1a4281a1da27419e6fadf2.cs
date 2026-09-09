namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (9RuCTxpsgUKh2idBnm+t8g)
///  <code>RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2</code> that represents <code>PI_HEADER_CECORecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_HEADER_CECORecord
public partial struct RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 : ITypedRecord<RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2> {
internal static readonly GlobalObjectKey IdPI_HEADER_CECO = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*W9rR_02+_+RGxy+8E_D34g");

public ST_b76a29481a19f994f96cb0bc4134fe6dStructure ssSTPI_HEADER_CECO;


public static implicit operator ST_b76a29481a19f994f96cb0bc4134fe6dStructure( RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 r) {
return r.ssSTPI_HEADER_CECO;
}

public static implicit operator RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 (ST_b76a29481a19f994f96cb0bc4134fe6dStructure r) {
RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 res = new RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 ();
res.ssSTPI_HEADER_CECO = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2() {
OptimizedAttributes = null;
ssSTPI_HEADER_CECO = new ST_b76a29481a19f994f96cb0bc4134fe6dStructure();
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
    ssSTPI_HEADER_CECO.OptimizedAttributes = value[0];
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
ssSTPI_HEADER_CECO.Read( r, ref index);
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
public void ReadIM(RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 r) {
this = r;
}


public static bool operator == (RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 a, RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 b) {
if (a.ssSTPI_HEADER_CECO != b.ssSTPI_HEADER_CECO) return false;
return true;
}

public static bool operator != (RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 a, RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2)) return false;
return (this == (RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_HEADER_CECO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_HEADER_CECO.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_HEADER_CECO.InternalRecursiveSave();
}


public RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 Duplicate() {
RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 t;
t.ssSTPI_HEADER_CECO = (ST_b76a29481a19f994f96cb0bc4134fe6dStructure)this.ssSTPI_HEADER_CECO.Duplicate();
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
if (head == "pi_header_ceco") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER_CECO")) variable.Value = ssSTPI_HEADER_CECO; else variable.Optimized = true;
variable.SetFieldName("pi_header_ceco");
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
if (key == IdPI_HEADER_CECO) {
return ssSTPI_HEADER_CECO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER_CECO.Key.AsGuid) {
return ssSTPI_HEADER_CECO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_HEADER_CECO.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER_CECO));
}
} // RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2
/// <summary>
/// RecordList type <code>PI_HEADER_CECORecordList</code> that represents a record list of
///  <code>PI_HEADER_CECO</code>
/// </summary>
public partial class RL_9e4aac6194bd554cc9f32206ab69cce8 : GenericRecordList<RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2>, IEnumerable, IEnumerator {

protected override RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2 GetElementDefaultValue() {
return new RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2();
}

public T[] ToArray<T>(Func<RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9e4aac6194bd554cc9f32206ab69cce8 recordList, Func<RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9e4aac6194bd554cc9f32206ab69cce8(RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2[] array) {
  RL_9e4aac6194bd554cc9f32206ab69cce8 result = new RL_9e4aac6194bd554cc9f32206ab69cce8();
result.InnerFromArray(array);
    return result;
}

public static RL_9e4aac6194bd554cc9f32206ab69cce8 ToList<T>(T[] array, Func <T, RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2> converter) {
  RL_9e4aac6194bd554cc9f32206ab69cce8 result = new RL_9e4aac6194bd554cc9f32206ab69cce8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9e4aac6194bd554cc9f32206ab69cce8 FromRestList<T>(RestList<T> restList, Func <T, RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2> converter) {
  RL_9e4aac6194bd554cc9f32206ab69cce8 result = new RL_9e4aac6194bd554cc9f32206ab69cce8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9e4aac6194bd554cc9f32206ab69cce8() : base() {
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
protected override OSList<RC_ffd1da5bbe4de4ff46c72fbc13f0f7e2> NewList() {
return new RL_9e4aac6194bd554cc9f32206ab69cce8();
}


} // RL_9e4aac6194bd554cc9f32206ab69cce8
}

