namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (IVwVtzT1Lkmg8zhAVapj+A)
///  <code>RC_cfaae8999ef94e08eeea036a2e8810d7</code> that represents <code>TimeZoneRecordRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TimeZoneRecordRecord
public partial struct RC_cfaae8999ef94e08eeea036a2e8810d7 : ITypedRecord<RC_cfaae8999ef94e08eeea036a2e8810d7>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdTimeZoneRecord = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*meiqz_meCE7u6gNqLogQ1w");

public ST_98371f99cd7bfeee4fab07e43606a1b5Structure ssSTTimeZoneRecord;


public static implicit operator ST_98371f99cd7bfeee4fab07e43606a1b5Structure( RC_cfaae8999ef94e08eeea036a2e8810d7 r) {
return r.ssSTTimeZoneRecord;
}

public static implicit operator RC_cfaae8999ef94e08eeea036a2e8810d7 (ST_98371f99cd7bfeee4fab07e43606a1b5Structure r) {
RC_cfaae8999ef94e08eeea036a2e8810d7 res = new RC_cfaae8999ef94e08eeea036a2e8810d7 ();
res.ssSTTimeZoneRecord = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_cfaae8999ef94e08eeea036a2e8810d7() {
OptimizedAttributes = null;
ssSTTimeZoneRecord = new ST_98371f99cd7bfeee4fab07e43606a1b5Structure();
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
    ssSTTimeZoneRecord.OptimizedAttributes = value[0];
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
ssSTTimeZoneRecord.Read( r, ref index);
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
public void ReadIM(RC_cfaae8999ef94e08eeea036a2e8810d7 r) {
this = r;
}


public static bool operator == (RC_cfaae8999ef94e08eeea036a2e8810d7 a, RC_cfaae8999ef94e08eeea036a2e8810d7 b) {
if (a.ssSTTimeZoneRecord != b.ssSTTimeZoneRecord) return false;
return true;
}

public static bool operator != (RC_cfaae8999ef94e08eeea036a2e8810d7 a, RC_cfaae8999ef94e08eeea036a2e8810d7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cfaae8999ef94e08eeea036a2e8810d7)) return false;
return (this == (RC_cfaae8999ef94e08eeea036a2e8810d7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTimeZoneRecord.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTimeZoneRecord.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTimeZoneRecord.InternalRecursiveSave();
}


public RC_cfaae8999ef94e08eeea036a2e8810d7 Duplicate() {
RC_cfaae8999ef94e08eeea036a2e8810d7 t;
t.ssSTTimeZoneRecord = (ST_98371f99cd7bfeee4fab07e43606a1b5Structure)this.ssSTTimeZoneRecord.Duplicate();
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
if (head == "timezonerecord") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TimeZoneRecord")) variable.Value = ssSTTimeZoneRecord; else variable.Optimized = true;
variable.SetFieldName("timezonerecord");
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
if (key == IdTimeZoneRecord) {
return ssSTTimeZoneRecord;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTimeZoneRecord.Key.AsGuid) {
return ssSTTimeZoneRecord;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTimeZoneRecord.FillFromOther((IRecord) other.AttributeGet(IdTimeZoneRecord));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTTimeZoneRecord.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdTimeZoneRecord.Key.AsGuid));
}
} // RC_cfaae8999ef94e08eeea036a2e8810d7
/// <summary>
/// RecordList type <code>TimeZoneRecordRecordList</code> that represents a record list of
///  <code>TimeZoneRecord</code>
/// </summary>
public partial class RL_1c8a15b369ab8805e11c4651bce7a4c8 : GenericRecordList<RC_cfaae8999ef94e08eeea036a2e8810d7>, IEnumerable, IEnumerator {

protected override RC_cfaae8999ef94e08eeea036a2e8810d7 GetElementDefaultValue() {
return new RC_cfaae8999ef94e08eeea036a2e8810d7();
}

public T[] ToArray<T>(Func<RC_cfaae8999ef94e08eeea036a2e8810d7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1c8a15b369ab8805e11c4651bce7a4c8 recordList, Func<RC_cfaae8999ef94e08eeea036a2e8810d7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1c8a15b369ab8805e11c4651bce7a4c8(RC_cfaae8999ef94e08eeea036a2e8810d7[] array) {
  RL_1c8a15b369ab8805e11c4651bce7a4c8 result = new RL_1c8a15b369ab8805e11c4651bce7a4c8();
result.InnerFromArray(array);
    return result;
}

public static RL_1c8a15b369ab8805e11c4651bce7a4c8 ToList<T>(T[] array, Func <T, RC_cfaae8999ef94e08eeea036a2e8810d7> converter) {
  RL_1c8a15b369ab8805e11c4651bce7a4c8 result = new RL_1c8a15b369ab8805e11c4651bce7a4c8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1c8a15b369ab8805e11c4651bce7a4c8 FromRestList<T>(RestList<T> restList, Func <T, RC_cfaae8999ef94e08eeea036a2e8810d7> converter) {
  RL_1c8a15b369ab8805e11c4651bce7a4c8 result = new RL_1c8a15b369ab8805e11c4651bce7a4c8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1c8a15b369ab8805e11c4651bce7a4c8() : base() {
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
protected override OSList<RC_cfaae8999ef94e08eeea036a2e8810d7> NewList() {
return new RL_1c8a15b369ab8805e11c4651bce7a4c8();
}


} // RL_1c8a15b369ab8805e11c4651bce7a4c8
}

