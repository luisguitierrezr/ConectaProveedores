namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (O1okHXU++UqUoW6ancrThA)
///  <code>RC_ad92b2c217228db10c71baf90a615ea5</code> that represents <code>FolioExtendedRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioExtendedRecord
public partial struct RC_ad92b2c217228db10c71baf90a615ea5 : ITypedRecord<RC_ad92b2c217228db10c71baf90a615ea5> {
internal static readonly GlobalObjectKey IdFolioExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wrKSrSIXsY0Mcbr5CmFepQ");

public EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord ssENFolioExtended;


public static implicit operator EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord( RC_ad92b2c217228db10c71baf90a615ea5 r) {
return r.ssENFolioExtended;
}

public static implicit operator RC_ad92b2c217228db10c71baf90a615ea5 (EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord r) {
RC_ad92b2c217228db10c71baf90a615ea5 res = new RC_ad92b2c217228db10c71baf90a615ea5 ();
res.ssENFolioExtended = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolioExtended.ChangedAttributes = value;
}
get {
    return ssENFolioExtended.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ad92b2c217228db10c71baf90a615ea5() {
OptimizedAttributes = null;
ssENFolioExtended = new EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioExtended.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolioExtended.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolioExtended.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioExtended.Read( r, ref index);
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
public void ReadIM(RC_ad92b2c217228db10c71baf90a615ea5 r) {
this = r;
}


public static bool operator == (RC_ad92b2c217228db10c71baf90a615ea5 a, RC_ad92b2c217228db10c71baf90a615ea5 b) {
if (a.ssENFolioExtended != b.ssENFolioExtended) return false;
return true;
}

public static bool operator != (RC_ad92b2c217228db10c71baf90a615ea5 a, RC_ad92b2c217228db10c71baf90a615ea5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ad92b2c217228db10c71baf90a615ea5)) return false;
return (this == (RC_ad92b2c217228db10c71baf90a615ea5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioExtended.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioExtended.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioExtended.InternalRecursiveSave();
}


public RC_ad92b2c217228db10c71baf90a615ea5 Duplicate() {
RC_ad92b2c217228db10c71baf90a615ea5 t;
t.ssENFolioExtended = (EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord)this.ssENFolioExtended.Duplicate();
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
if (head == "folioextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioExtended")) variable.Value = ssENFolioExtended; else variable.Optimized = true;
variable.SetFieldName("folioextended");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolioExtended.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolioExtended.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioExtended) {
return ssENFolioExtended;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioExtended.Key.AsGuid) {
return ssENFolioExtended;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioExtended.FillFromOther((IRecord) other.AttributeGet(IdFolioExtended));
}
} // RC_ad92b2c217228db10c71baf90a615ea5
/// <summary>
/// RecordList type <code>FolioExtendedRecordList</code> that represents a record list of
///  <code>FolioExtended</code>
/// </summary>
public partial class RL_abf5dc59037dde79c92447e12cf9bfc9 : GenericRecordList<RC_ad92b2c217228db10c71baf90a615ea5>, IEnumerable, IEnumerator {

protected override RC_ad92b2c217228db10c71baf90a615ea5 GetElementDefaultValue() {
return new RC_ad92b2c217228db10c71baf90a615ea5();
}

public T[] ToArray<T>(Func<RC_ad92b2c217228db10c71baf90a615ea5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_abf5dc59037dde79c92447e12cf9bfc9 recordList, Func<RC_ad92b2c217228db10c71baf90a615ea5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_abf5dc59037dde79c92447e12cf9bfc9(RC_ad92b2c217228db10c71baf90a615ea5[] array) {
  RL_abf5dc59037dde79c92447e12cf9bfc9 result = new RL_abf5dc59037dde79c92447e12cf9bfc9();
result.InnerFromArray(array);
    return result;
}

public static RL_abf5dc59037dde79c92447e12cf9bfc9 ToList<T>(T[] array, Func <T, RC_ad92b2c217228db10c71baf90a615ea5> converter) {
  RL_abf5dc59037dde79c92447e12cf9bfc9 result = new RL_abf5dc59037dde79c92447e12cf9bfc9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_abf5dc59037dde79c92447e12cf9bfc9 FromRestList<T>(RestList<T> restList, Func <T, RC_ad92b2c217228db10c71baf90a615ea5> converter) {
  RL_abf5dc59037dde79c92447e12cf9bfc9 result = new RL_abf5dc59037dde79c92447e12cf9bfc9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_abf5dc59037dde79c92447e12cf9bfc9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ad92b2c217228db10c71baf90a615ea5> NewList() {
return new RL_abf5dc59037dde79c92447e12cf9bfc9();
}


} // RL_abf5dc59037dde79c92447e12cf9bfc9
}

