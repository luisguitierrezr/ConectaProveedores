namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (F2MCy9DDN0CGmzuG2dAJgg)
///  <code>RC_941bbff9017349761a37494fcd214b98</code> that represents <code>SegmentAccGroupRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SegmentAccGroupRecord
public partial struct RC_941bbff9017349761a37494fcd214b98 : ITypedRecord<RC_941bbff9017349761a37494fcd214b98> {
internal static readonly GlobalObjectKey IdSegmentAccGroup = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+b8blHMBdkkaN0lPzSFLmA");

public EN_029f0fb77a2785e324319f171edbc2c0EntityRecord ssENSegmentAccGroup;


public static implicit operator EN_029f0fb77a2785e324319f171edbc2c0EntityRecord( RC_941bbff9017349761a37494fcd214b98 r) {
return r.ssENSegmentAccGroup;
}

public static implicit operator RC_941bbff9017349761a37494fcd214b98 (EN_029f0fb77a2785e324319f171edbc2c0EntityRecord r) {
RC_941bbff9017349761a37494fcd214b98 res = new RC_941bbff9017349761a37494fcd214b98 ();
res.ssENSegmentAccGroup = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSegmentAccGroup.ChangedAttributes = value;
}
get {
    return ssENSegmentAccGroup.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_941bbff9017349761a37494fcd214b98() {
OptimizedAttributes = null;
ssENSegmentAccGroup = new EN_029f0fb77a2785e324319f171edbc2c0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSegmentAccGroup.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSegmentAccGroup.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSegmentAccGroup.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSegmentAccGroup.Read( r, ref index);
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
public void ReadIM(RC_941bbff9017349761a37494fcd214b98 r) {
this = r;
}


public static bool operator == (RC_941bbff9017349761a37494fcd214b98 a, RC_941bbff9017349761a37494fcd214b98 b) {
if (a.ssENSegmentAccGroup != b.ssENSegmentAccGroup) return false;
return true;
}

public static bool operator != (RC_941bbff9017349761a37494fcd214b98 a, RC_941bbff9017349761a37494fcd214b98 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_941bbff9017349761a37494fcd214b98)) return false;
return (this == (RC_941bbff9017349761a37494fcd214b98)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSegmentAccGroup.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSegmentAccGroup.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSegmentAccGroup.InternalRecursiveSave();
}


public RC_941bbff9017349761a37494fcd214b98 Duplicate() {
RC_941bbff9017349761a37494fcd214b98 t;
t.ssENSegmentAccGroup = (EN_029f0fb77a2785e324319f171edbc2c0EntityRecord)this.ssENSegmentAccGroup.Duplicate();
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
if (head == "segmentaccgroup") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SegmentAccGroup")) variable.Value = ssENSegmentAccGroup; else variable.Optimized = true;
variable.SetFieldName("segmentaccgroup");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSegmentAccGroup.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSegmentAccGroup.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSegmentAccGroup) {
return ssENSegmentAccGroup;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSegmentAccGroup.Key.AsGuid) {
return ssENSegmentAccGroup;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSegmentAccGroup.FillFromOther((IRecord) other.AttributeGet(IdSegmentAccGroup));
}
} // RC_941bbff9017349761a37494fcd214b98
/// <summary>
/// RecordList type <code>SegmentAccGroupRecordList</code> that represents a record list of
///  <code>SegmentAccGroup</code>
/// </summary>
public partial class RL_152426fe5cee70257c3c100a9c6eadad : GenericRecordList<RC_941bbff9017349761a37494fcd214b98>, IEnumerable, IEnumerator {

protected override RC_941bbff9017349761a37494fcd214b98 GetElementDefaultValue() {
return new RC_941bbff9017349761a37494fcd214b98();
}

public T[] ToArray<T>(Func<RC_941bbff9017349761a37494fcd214b98, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_152426fe5cee70257c3c100a9c6eadad recordList, Func<RC_941bbff9017349761a37494fcd214b98, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_152426fe5cee70257c3c100a9c6eadad(RC_941bbff9017349761a37494fcd214b98[] array) {
  RL_152426fe5cee70257c3c100a9c6eadad result = new RL_152426fe5cee70257c3c100a9c6eadad();
result.InnerFromArray(array);
    return result;
}

public static RL_152426fe5cee70257c3c100a9c6eadad ToList<T>(T[] array, Func <T, RC_941bbff9017349761a37494fcd214b98> converter) {
  RL_152426fe5cee70257c3c100a9c6eadad result = new RL_152426fe5cee70257c3c100a9c6eadad();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_152426fe5cee70257c3c100a9c6eadad FromRestList<T>(RestList<T> restList, Func <T, RC_941bbff9017349761a37494fcd214b98> converter) {
  RL_152426fe5cee70257c3c100a9c6eadad result = new RL_152426fe5cee70257c3c100a9c6eadad();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_152426fe5cee70257c3c100a9c6eadad() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_941bbff9017349761a37494fcd214b98> NewList() {
return new RL_152426fe5cee70257c3c100a9c6eadad();
}


} // RL_152426fe5cee70257c3c100a9c6eadad
}

