namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (JSjKaAuyK0myq4x_FOUucA)
///  <code>RC_7906bb6b983a6dbe393ae00113e19275</code> that represent
/// s <code>UpdateIsToCancelFoliosPositionRecord</code> <p>Description: </p>
/// </summary>
// Name: UpdateIsToCancelFoliosPositionRecord
public partial struct RC_7906bb6b983a6dbe393ae00113e19275 : ITypedRecord<RC_7906bb6b983a6dbe393ae00113e19275> {
internal static readonly GlobalObjectKey IdUpdate = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*auDHpouUb2D_dAnvWEAOjw");
internal static readonly GlobalObjectKey IdIsToCancelFolios = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LMTnOCU3qfI1i+B+8_aprQ");
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sNJSwVFqvP9h3kR2IiKgMQ");

public string ssUpdate;

public bool ssIsToCancelFolios;

public int ssPosition;


public BitArray OptimizedAttributes;

public RC_7906bb6b983a6dbe393ae00113e19275() {
OptimizedAttributes = null;
ssUpdate = "";
ssIsToCancelFolios = false;
ssPosition = 0;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssUpdate = r.ReadText(index++, "UpdateIsToCancelFoliosPositionRecord.Update", "");
ssIsToCancelFolios = r.ReadBoolean(index++, "UpdateIsToCancelFoliosPositionRecord.IsToCancelFolios", false);
ssPosition = r.ReadInteger(index++, "UpdateIsToCancelFoliosPositionRecord.Position", 0);
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
public void ReadIM(RC_7906bb6b983a6dbe393ae00113e19275 r) {
this = r;
}


public static bool operator == (RC_7906bb6b983a6dbe393ae00113e19275 a, RC_7906bb6b983a6dbe393ae00113e19275 b) {
if (a.ssUpdate != b.ssUpdate) return false;
if (a.ssIsToCancelFolios != b.ssIsToCancelFolios) return false;
if (a.ssPosition != b.ssPosition) return false;
return true;
}

public static bool operator != (RC_7906bb6b983a6dbe393ae00113e19275 a, RC_7906bb6b983a6dbe393ae00113e19275 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7906bb6b983a6dbe393ae00113e19275)) return false;
return (this == (RC_7906bb6b983a6dbe393ae00113e19275)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUpdate.GetHashCode()
 ^ ssIsToCancelFolios.GetHashCode()
 ^ ssPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_7906bb6b983a6dbe393ae00113e19275 Duplicate() {
RC_7906bb6b983a6dbe393ae00113e19275 t;
t.ssUpdate = this.ssUpdate;
t.ssIsToCancelFolios = this.ssIsToCancelFolios;
t.ssPosition = this.ssPosition;
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
if (head == "update") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Update")) variable.Value = ssUpdate; else variable.Optimized = true;
} else if (head == "istocancelfolios") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsToCancelFolios")) variable.Value = ssIsToCancelFolios; else variable.Optimized = true;
} else if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Position")) variable.Value = ssPosition; else variable.Optimized = true;
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
if (key == IdUpdate) {
return ssUpdate;
}
if (key == IdIsToCancelFolios) {
return ssIsToCancelFolios;
}
if (key == IdPosition) {
return ssPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUpdate.Key.AsGuid) {
return ssUpdate;
}
if (attributeKey == IdIsToCancelFolios.Key.AsGuid) {
return ssIsToCancelFolios;
}
if (attributeKey == IdPosition.Key.AsGuid) {
return ssPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUpdate = (string) other.AttributeGet(IdUpdate);
ssIsToCancelFolios = (bool) other.AttributeGet(IdIsToCancelFolios);
ssPosition = (int) other.AttributeGet(IdPosition);
}
} // RC_7906bb6b983a6dbe393ae00113e19275
/// <summary>
/// RecordList type <code>UpdateIsToCancelFoliosPositionRecordList</code> that represents a record list
///  of <code>Text, Boolean, Integer</code>
/// </summary>
public partial class RL_0db625824c10f393ed4c09b71230571f : GenericRecordList<RC_7906bb6b983a6dbe393ae00113e19275>, IEnumerable, IEnumerator {

protected override RC_7906bb6b983a6dbe393ae00113e19275 GetElementDefaultValue() {
return new RC_7906bb6b983a6dbe393ae00113e19275();
}

public T[] ToArray<T>(Func<RC_7906bb6b983a6dbe393ae00113e19275, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0db625824c10f393ed4c09b71230571f recordList, Func<RC_7906bb6b983a6dbe393ae00113e19275, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0db625824c10f393ed4c09b71230571f(RC_7906bb6b983a6dbe393ae00113e19275[] array) {
  RL_0db625824c10f393ed4c09b71230571f result = new RL_0db625824c10f393ed4c09b71230571f();
result.InnerFromArray(array);
    return result;
}

public static RL_0db625824c10f393ed4c09b71230571f ToList<T>(T[] array, Func <T, RC_7906bb6b983a6dbe393ae00113e19275> converter) {
  RL_0db625824c10f393ed4c09b71230571f result = new RL_0db625824c10f393ed4c09b71230571f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0db625824c10f393ed4c09b71230571f FromRestList<T>(RestList<T> restList, Func <T, RC_7906bb6b983a6dbe393ae00113e19275> converter) {
  RL_0db625824c10f393ed4c09b71230571f result = new RL_0db625824c10f393ed4c09b71230571f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0db625824c10f393ed4c09b71230571f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7906bb6b983a6dbe393ae00113e19275> NewList() {
return new RL_0db625824c10f393ed4c09b71230571f();
}


} // RL_0db625824c10f393ed4c09b71230571f
}

