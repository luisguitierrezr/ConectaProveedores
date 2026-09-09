namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6C6y4vm9f0eA7cOdbCjoZA)
///  <code>RC_f92e28910a28340f3e2c5d63e6bdfe4a</code> that represents <code>OcrResultRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OcrResultRecord
public partial struct RC_f92e28910a28340f3e2c5d63e6bdfe4a : ITypedRecord<RC_f92e28910a28340f3e2c5d63e6bdfe4a>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdOcrResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kSgu+SgKDzQ+LF1j5r3+Sg");

public ST_ce06f43cf108d98e4f79c0106fcfd0acStructure ssSTOcrResult;


public static implicit operator ST_ce06f43cf108d98e4f79c0106fcfd0acStructure( RC_f92e28910a28340f3e2c5d63e6bdfe4a r) {
return r.ssSTOcrResult;
}

public static implicit operator RC_f92e28910a28340f3e2c5d63e6bdfe4a (ST_ce06f43cf108d98e4f79c0106fcfd0acStructure r) {
RC_f92e28910a28340f3e2c5d63e6bdfe4a res = new RC_f92e28910a28340f3e2c5d63e6bdfe4a ();
res.ssSTOcrResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f92e28910a28340f3e2c5d63e6bdfe4a() {
OptimizedAttributes = null;
ssSTOcrResult = new ST_ce06f43cf108d98e4f79c0106fcfd0acStructure();
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
    ssSTOcrResult.OptimizedAttributes = value[0];
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
ssSTOcrResult.Read( r, ref index);
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
public void ReadIM(RC_f92e28910a28340f3e2c5d63e6bdfe4a r) {
this = r;
}


public static bool operator == (RC_f92e28910a28340f3e2c5d63e6bdfe4a a, RC_f92e28910a28340f3e2c5d63e6bdfe4a b) {
if (a.ssSTOcrResult != b.ssSTOcrResult) return false;
return true;
}

public static bool operator != (RC_f92e28910a28340f3e2c5d63e6bdfe4a a, RC_f92e28910a28340f3e2c5d63e6bdfe4a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f92e28910a28340f3e2c5d63e6bdfe4a)) return false;
return (this == (RC_f92e28910a28340f3e2c5d63e6bdfe4a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOcrResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOcrResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOcrResult.InternalRecursiveSave();
}


public RC_f92e28910a28340f3e2c5d63e6bdfe4a Duplicate() {
RC_f92e28910a28340f3e2c5d63e6bdfe4a t;
t.ssSTOcrResult = (ST_ce06f43cf108d98e4f79c0106fcfd0acStructure)this.ssSTOcrResult.Duplicate();
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
if (head == "ocrresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OcrResult")) variable.Value = ssSTOcrResult; else variable.Optimized = true;
variable.SetFieldName("ocrresult");
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
if (key == IdOcrResult) {
return ssSTOcrResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOcrResult.Key.AsGuid) {
return ssSTOcrResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOcrResult.FillFromOther((IRecord) other.AttributeGet(IdOcrResult));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTOcrResult.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdOcrResult.Key.AsGuid));
}
} // RC_f92e28910a28340f3e2c5d63e6bdfe4a
/// <summary>
/// RecordList type <code>OcrResultRecordList</code> that represents a record list of
///  <code>OcrResult</code>
/// </summary>
public partial class RL_64235540980fadfede2d7f86bc70cac0 : GenericRecordList<RC_f92e28910a28340f3e2c5d63e6bdfe4a>, IEnumerable, IEnumerator {

protected override RC_f92e28910a28340f3e2c5d63e6bdfe4a GetElementDefaultValue() {
return new RC_f92e28910a28340f3e2c5d63e6bdfe4a();
}

public T[] ToArray<T>(Func<RC_f92e28910a28340f3e2c5d63e6bdfe4a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_64235540980fadfede2d7f86bc70cac0 recordList, Func<RC_f92e28910a28340f3e2c5d63e6bdfe4a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_64235540980fadfede2d7f86bc70cac0(RC_f92e28910a28340f3e2c5d63e6bdfe4a[] array) {
  RL_64235540980fadfede2d7f86bc70cac0 result = new RL_64235540980fadfede2d7f86bc70cac0();
result.InnerFromArray(array);
    return result;
}

public static RL_64235540980fadfede2d7f86bc70cac0 ToList<T>(T[] array, Func <T, RC_f92e28910a28340f3e2c5d63e6bdfe4a> converter) {
  RL_64235540980fadfede2d7f86bc70cac0 result = new RL_64235540980fadfede2d7f86bc70cac0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_64235540980fadfede2d7f86bc70cac0 FromRestList<T>(RestList<T> restList, Func <T, RC_f92e28910a28340f3e2c5d63e6bdfe4a> converter) {
  RL_64235540980fadfede2d7f86bc70cac0 result = new RL_64235540980fadfede2d7f86bc70cac0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_64235540980fadfede2d7f86bc70cac0() : base() {
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
protected override OSList<RC_f92e28910a28340f3e2c5d63e6bdfe4a> NewList() {
return new RL_64235540980fadfede2d7f86bc70cac0();
}


} // RL_64235540980fadfede2d7f86bc70cac0
}

