namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (GgIcHBwgok+N0R_wN9XdOw)
///  <code>RC_dbac6e35b37e102dd601262a956066d2</code> that represent
/// s <code>SegmentAccGroupSegmentAccGroupTelcelDirRecord</code> <p>Description: </p>
/// </summary>
// Name: SegmentAccGroupSegmentAccGroupTelcelDirRecord
public partial struct RC_dbac6e35b37e102dd601262a956066d2 : ITypedRecord<RC_dbac6e35b37e102dd601262a956066d2> {
internal static readonly GlobalObjectKey IdSegmentAccGroup = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+b8blHMBdkkaN0lPzSFLmA");
internal static readonly GlobalObjectKey IdSegmentAccGroupTelcelDir = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ld74eGfoyMweq7BUloy_Ww");

public EN_029f0fb77a2785e324319f171edbc2c0EntityRecord ssENSegmentAccGroup;

public EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord ssENSegmentAccGroupTelcelDir;


public BitArray OptimizedAttributes;

public RC_dbac6e35b37e102dd601262a956066d2() {
OptimizedAttributes = null;
ssENSegmentAccGroup = new EN_029f0fb77a2785e324319f171edbc2c0EntityRecord();
ssENSegmentAccGroupTelcelDir = new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(7,false);
    all[1] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSegmentAccGroup.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSegmentAccGroupTelcelDir.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENSegmentAccGroup.OptimizedAttributes = value[0];
    ssENSegmentAccGroupTelcelDir.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENSegmentAccGroup.OptimizedAttributes;
    all[1] = ssENSegmentAccGroupTelcelDir.OptimizedAttributes;
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
ssENSegmentAccGroupTelcelDir.Read( r, ref index);
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
public void ReadIM(RC_dbac6e35b37e102dd601262a956066d2 r) {
this = r;
}


public static bool operator == (RC_dbac6e35b37e102dd601262a956066d2 a, RC_dbac6e35b37e102dd601262a956066d2 b) {
if (a.ssENSegmentAccGroup != b.ssENSegmentAccGroup) return false;
if (a.ssENSegmentAccGroupTelcelDir != b.ssENSegmentAccGroupTelcelDir) return false;
return true;
}

public static bool operator != (RC_dbac6e35b37e102dd601262a956066d2 a, RC_dbac6e35b37e102dd601262a956066d2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dbac6e35b37e102dd601262a956066d2)) return false;
return (this == (RC_dbac6e35b37e102dd601262a956066d2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSegmentAccGroup.GetHashCode()
 ^ ssENSegmentAccGroupTelcelDir.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSegmentAccGroup.RecursiveReset();
ssENSegmentAccGroupTelcelDir.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSegmentAccGroup.InternalRecursiveSave();
ssENSegmentAccGroupTelcelDir.InternalRecursiveSave();
}


public RC_dbac6e35b37e102dd601262a956066d2 Duplicate() {
RC_dbac6e35b37e102dd601262a956066d2 t;
t.ssENSegmentAccGroup = (EN_029f0fb77a2785e324319f171edbc2c0EntityRecord)this.ssENSegmentAccGroup.Duplicate();
t.ssENSegmentAccGroupTelcelDir = (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord)this.ssENSegmentAccGroupTelcelDir.Duplicate();
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
} else if (head == "segmentaccgrouptelceldir") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SegmentAccGroupTelcelDir")) variable.Value = ssENSegmentAccGroupTelcelDir; else variable.Optimized = true;
variable.SetFieldName("segmentaccgrouptelceldir");
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
if (key == IdSegmentAccGroup) {
return ssENSegmentAccGroup;
}
if (key == IdSegmentAccGroupTelcelDir) {
return ssENSegmentAccGroupTelcelDir;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSegmentAccGroup.Key.AsGuid) {
return ssENSegmentAccGroup;
}
if (attributeKey == IdSegmentAccGroupTelcelDir.Key.AsGuid) {
return ssENSegmentAccGroupTelcelDir;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSegmentAccGroup.FillFromOther((IRecord) other.AttributeGet(IdSegmentAccGroup));
ssENSegmentAccGroupTelcelDir.FillFromOther((IRecord) other.AttributeGet(IdSegmentAccGroupTelcelDir));
}
} // RC_dbac6e35b37e102dd601262a956066d2
/// <summary>
/// RecordList type <code>SegmentAccGroupSegmentAccGroupTelcelDirRecordList</code> that represents a
///  record list of <code>SegmentAccGroup, SegmentAccGroupTelcelDir</code>
/// </summary>
public partial class RL_4b6f9359ce9887bc6f37c96ecf62266d : GenericRecordList<RC_dbac6e35b37e102dd601262a956066d2>, IEnumerable, IEnumerator {

protected override RC_dbac6e35b37e102dd601262a956066d2 GetElementDefaultValue() {
return new RC_dbac6e35b37e102dd601262a956066d2();
}

public T[] ToArray<T>(Func<RC_dbac6e35b37e102dd601262a956066d2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4b6f9359ce9887bc6f37c96ecf62266d recordList, Func<RC_dbac6e35b37e102dd601262a956066d2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4b6f9359ce9887bc6f37c96ecf62266d(RC_dbac6e35b37e102dd601262a956066d2[] array) {
  RL_4b6f9359ce9887bc6f37c96ecf62266d result = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
result.InnerFromArray(array);
    return result;
}

public static RL_4b6f9359ce9887bc6f37c96ecf62266d ToList<T>(T[] array, Func <T, RC_dbac6e35b37e102dd601262a956066d2> converter) {
  RL_4b6f9359ce9887bc6f37c96ecf62266d result = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4b6f9359ce9887bc6f37c96ecf62266d FromRestList<T>(RestList<T> restList, Func <T, RC_dbac6e35b37e102dd601262a956066d2> converter) {
  RL_4b6f9359ce9887bc6f37c96ecf62266d result = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4b6f9359ce9887bc6f37c96ecf62266d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(7,false);
def[1] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_dbac6e35b37e102dd601262a956066d2> NewList() {
return new RL_4b6f9359ce9887bc6f37c96ecf62266d();
}


} // RL_4b6f9359ce9887bc6f37c96ecf62266d
}

