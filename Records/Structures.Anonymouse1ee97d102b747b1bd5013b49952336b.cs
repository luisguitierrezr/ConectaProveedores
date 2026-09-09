namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (0Zfu4bcCsUe9UBO0mVIzaw)
///  <code>RC_b5715a31bd56ae3cc671ee9419cb6075</code> that represents <code>FolioQRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioQRecord
public partial struct RC_b5715a31bd56ae3cc671ee9419cb6075 : ITypedRecord<RC_b5715a31bd56ae3cc671ee9419cb6075> {
internal static readonly GlobalObjectKey IdFolioQ = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MVpxtVa9PK7Gce6UGctgdQ");

public ST_118fe20454dd0bf1f0e6d925e7d7544bStructure ssSTFolioQ;


public static implicit operator ST_118fe20454dd0bf1f0e6d925e7d7544bStructure( RC_b5715a31bd56ae3cc671ee9419cb6075 r) {
return r.ssSTFolioQ;
}

public static implicit operator RC_b5715a31bd56ae3cc671ee9419cb6075 (ST_118fe20454dd0bf1f0e6d925e7d7544bStructure r) {
RC_b5715a31bd56ae3cc671ee9419cb6075 res = new RC_b5715a31bd56ae3cc671ee9419cb6075 ();
res.ssSTFolioQ = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b5715a31bd56ae3cc671ee9419cb6075() {
OptimizedAttributes = null;
ssSTFolioQ = new ST_118fe20454dd0bf1f0e6d925e7d7544bStructure();
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
    ssSTFolioQ.OptimizedAttributes = value[0];
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
ssSTFolioQ.Read( r, ref index);
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
public void ReadIM(RC_b5715a31bd56ae3cc671ee9419cb6075 r) {
this = r;
}


public static bool operator == (RC_b5715a31bd56ae3cc671ee9419cb6075 a, RC_b5715a31bd56ae3cc671ee9419cb6075 b) {
if (a.ssSTFolioQ != b.ssSTFolioQ) return false;
return true;
}

public static bool operator != (RC_b5715a31bd56ae3cc671ee9419cb6075 a, RC_b5715a31bd56ae3cc671ee9419cb6075 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b5715a31bd56ae3cc671ee9419cb6075)) return false;
return (this == (RC_b5715a31bd56ae3cc671ee9419cb6075)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioQ.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioQ.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioQ.InternalRecursiveSave();
}


public RC_b5715a31bd56ae3cc671ee9419cb6075 Duplicate() {
RC_b5715a31bd56ae3cc671ee9419cb6075 t;
t.ssSTFolioQ = (ST_118fe20454dd0bf1f0e6d925e7d7544bStructure)this.ssSTFolioQ.Duplicate();
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
if (head == "folioq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioQ")) variable.Value = ssSTFolioQ; else variable.Optimized = true;
variable.SetFieldName("folioq");
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
if (key == IdFolioQ) {
return ssSTFolioQ;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioQ.Key.AsGuid) {
return ssSTFolioQ;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioQ.FillFromOther((IRecord) other.AttributeGet(IdFolioQ));
}
} // RC_b5715a31bd56ae3cc671ee9419cb6075
/// <summary>
/// RecordList type <code>FolioQRecordList</code> that represents a record list of <code>FolioQ</code>
/// </summary>
public partial class RL_a88bb8a60ee98183aa751302a5ef451c : GenericRecordList<RC_b5715a31bd56ae3cc671ee9419cb6075>, IEnumerable, IEnumerator {

protected override RC_b5715a31bd56ae3cc671ee9419cb6075 GetElementDefaultValue() {
return new RC_b5715a31bd56ae3cc671ee9419cb6075();
}

public T[] ToArray<T>(Func<RC_b5715a31bd56ae3cc671ee9419cb6075, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a88bb8a60ee98183aa751302a5ef451c recordList, Func<RC_b5715a31bd56ae3cc671ee9419cb6075, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a88bb8a60ee98183aa751302a5ef451c(RC_b5715a31bd56ae3cc671ee9419cb6075[] array) {
  RL_a88bb8a60ee98183aa751302a5ef451c result = new RL_a88bb8a60ee98183aa751302a5ef451c();
result.InnerFromArray(array);
    return result;
}

public static RL_a88bb8a60ee98183aa751302a5ef451c ToList<T>(T[] array, Func <T, RC_b5715a31bd56ae3cc671ee9419cb6075> converter) {
  RL_a88bb8a60ee98183aa751302a5ef451c result = new RL_a88bb8a60ee98183aa751302a5ef451c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a88bb8a60ee98183aa751302a5ef451c FromRestList<T>(RestList<T> restList, Func <T, RC_b5715a31bd56ae3cc671ee9419cb6075> converter) {
  RL_a88bb8a60ee98183aa751302a5ef451c result = new RL_a88bb8a60ee98183aa751302a5ef451c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a88bb8a60ee98183aa751302a5ef451c() : base() {
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
protected override OSList<RC_b5715a31bd56ae3cc671ee9419cb6075> NewList() {
return new RL_a88bb8a60ee98183aa751302a5ef451c();
}


} // RL_a88bb8a60ee98183aa751302a5ef451c
}

