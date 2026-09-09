namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (UXJaBnrsLkWjya_PbTmdRg)
///  <code>RC_67d1fce35b851f9d35f4c07471a88bc9</code> that represent
/// s <code>DocumentExtrationOutputRecord</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationOutputRecord
public partial struct RC_67d1fce35b851f9d35f4c07471a88bc9 : ITypedRecord<RC_67d1fce35b851f9d35f4c07471a88bc9> {
internal static readonly GlobalObjectKey IdDocumentExtrationOutput = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4_zRZ4VbnR819MB0caiLyQ");

public ST_37a6487c1fae199ee92f583d495139beStructure ssSTDocumentExtrationOutput;


public static implicit operator ST_37a6487c1fae199ee92f583d495139beStructure( RC_67d1fce35b851f9d35f4c07471a88bc9 r) {
return r.ssSTDocumentExtrationOutput;
}

public static implicit operator RC_67d1fce35b851f9d35f4c07471a88bc9 (ST_37a6487c1fae199ee92f583d495139beStructure r) {
RC_67d1fce35b851f9d35f4c07471a88bc9 res = new RC_67d1fce35b851f9d35f4c07471a88bc9 ();
res.ssSTDocumentExtrationOutput = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_67d1fce35b851f9d35f4c07471a88bc9() {
OptimizedAttributes = null;
ssSTDocumentExtrationOutput = new ST_37a6487c1fae199ee92f583d495139beStructure();
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
    ssSTDocumentExtrationOutput.OptimizedAttributes = value[0];
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
ssSTDocumentExtrationOutput.Read( r, ref index);
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
public void ReadIM(RC_67d1fce35b851f9d35f4c07471a88bc9 r) {
this = r;
}


public static bool operator == (RC_67d1fce35b851f9d35f4c07471a88bc9 a, RC_67d1fce35b851f9d35f4c07471a88bc9 b) {
if (a.ssSTDocumentExtrationOutput != b.ssSTDocumentExtrationOutput) return false;
return true;
}

public static bool operator != (RC_67d1fce35b851f9d35f4c07471a88bc9 a, RC_67d1fce35b851f9d35f4c07471a88bc9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_67d1fce35b851f9d35f4c07471a88bc9)) return false;
return (this == (RC_67d1fce35b851f9d35f4c07471a88bc9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDocumentExtrationOutput.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDocumentExtrationOutput.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDocumentExtrationOutput.InternalRecursiveSave();
}


public RC_67d1fce35b851f9d35f4c07471a88bc9 Duplicate() {
RC_67d1fce35b851f9d35f4c07471a88bc9 t;
t.ssSTDocumentExtrationOutput = (ST_37a6487c1fae199ee92f583d495139beStructure)this.ssSTDocumentExtrationOutput.Duplicate();
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
if (head == "documentextrationoutput") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentExtrationOutput")) variable.Value = ssSTDocumentExtrationOutput; else variable.Optimized = true;
variable.SetFieldName("documentextrationoutput");
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
if (key == IdDocumentExtrationOutput) {
return ssSTDocumentExtrationOutput;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDocumentExtrationOutput.Key.AsGuid) {
return ssSTDocumentExtrationOutput;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDocumentExtrationOutput.FillFromOther((IRecord) other.AttributeGet(IdDocumentExtrationOutput));
}
} // RC_67d1fce35b851f9d35f4c07471a88bc9
/// <summary>
/// RecordList type <code>DocumentExtrationOutputRecordList</code> that represents a record list of
///  <code>DocumentExtrationOutput</code>
/// </summary>
public partial class RL_b4df27ce4b25161894d6542ba9ddf987 : GenericRecordList<RC_67d1fce35b851f9d35f4c07471a88bc9>, IEnumerable, IEnumerator {

protected override RC_67d1fce35b851f9d35f4c07471a88bc9 GetElementDefaultValue() {
return new RC_67d1fce35b851f9d35f4c07471a88bc9();
}

public T[] ToArray<T>(Func<RC_67d1fce35b851f9d35f4c07471a88bc9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b4df27ce4b25161894d6542ba9ddf987 recordList, Func<RC_67d1fce35b851f9d35f4c07471a88bc9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b4df27ce4b25161894d6542ba9ddf987(RC_67d1fce35b851f9d35f4c07471a88bc9[] array) {
  RL_b4df27ce4b25161894d6542ba9ddf987 result = new RL_b4df27ce4b25161894d6542ba9ddf987();
result.InnerFromArray(array);
    return result;
}

public static RL_b4df27ce4b25161894d6542ba9ddf987 ToList<T>(T[] array, Func <T, RC_67d1fce35b851f9d35f4c07471a88bc9> converter) {
  RL_b4df27ce4b25161894d6542ba9ddf987 result = new RL_b4df27ce4b25161894d6542ba9ddf987();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b4df27ce4b25161894d6542ba9ddf987 FromRestList<T>(RestList<T> restList, Func <T, RC_67d1fce35b851f9d35f4c07471a88bc9> converter) {
  RL_b4df27ce4b25161894d6542ba9ddf987 result = new RL_b4df27ce4b25161894d6542ba9ddf987();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b4df27ce4b25161894d6542ba9ddf987() : base() {
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
protected override OSList<RC_67d1fce35b851f9d35f4c07471a88bc9> NewList() {
return new RL_b4df27ce4b25161894d6542ba9ddf987();
}


} // RL_b4df27ce4b25161894d6542ba9ddf987
}

