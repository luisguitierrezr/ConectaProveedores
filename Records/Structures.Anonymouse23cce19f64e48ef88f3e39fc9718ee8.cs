namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Gc484k7270iI8+OfyXGO6A)
///  <code>RC_3756803ceb487b3262b6a7da245b8a74</code> that represent
/// s <code>TelcelDirectionIdRecord</code> <p>Description: </p>
/// </summary>
// Name: TelcelDirectionIdRecord
public partial struct RC_3756803ceb487b3262b6a7da245b8a74 : ITypedRecord<RC_3756803ceb487b3262b6a7da245b8a74> {
internal static readonly GlobalObjectKey IdTelcelDirectionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PIBWN0jrMntitqfaJFuKdA");

public long ssTelcelDirectionId;


public BitArray OptimizedAttributes;

public RC_3756803ceb487b3262b6a7da245b8a74() {
OptimizedAttributes = null;
ssTelcelDirectionId = 0L;
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
ssTelcelDirectionId = r.ReadEntityReferenceLongInteger(index++, "TelcelDirectionIdRecord.TelcelDirectionId", 0L);
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
public void ReadIM(RC_3756803ceb487b3262b6a7da245b8a74 r) {
this = r;
}


public static bool operator == (RC_3756803ceb487b3262b6a7da245b8a74 a, RC_3756803ceb487b3262b6a7da245b8a74 b) {
if (a.ssTelcelDirectionId != b.ssTelcelDirectionId) return false;
return true;
}

public static bool operator != (RC_3756803ceb487b3262b6a7da245b8a74 a, RC_3756803ceb487b3262b6a7da245b8a74 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3756803ceb487b3262b6a7da245b8a74)) return false;
return (this == (RC_3756803ceb487b3262b6a7da245b8a74)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssTelcelDirectionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_3756803ceb487b3262b6a7da245b8a74 Duplicate() {
RC_3756803ceb487b3262b6a7da245b8a74 t;
t.ssTelcelDirectionId = this.ssTelcelDirectionId;
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
if (head == "telceldirectionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirectionId")) variable.Value = ssTelcelDirectionId; else variable.Optimized = true;
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
if (key == IdTelcelDirectionId) {
return ssTelcelDirectionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTelcelDirectionId.Key.AsGuid) {
return ssTelcelDirectionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssTelcelDirectionId = (long) other.AttributeGet(IdTelcelDirectionId);
}
} // RC_3756803ceb487b3262b6a7da245b8a74
/// <summary>
/// RecordList type <code>TelcelDirectionIdRecordList</code> that represents a record list of
///  <code>TelcelDirectionIdentifier</code>
/// </summary>
public partial class RL_605921a60a3ac4dd1382c185e90bacac : GenericRecordList<RC_3756803ceb487b3262b6a7da245b8a74>, IEnumerable, IEnumerator {

protected override RC_3756803ceb487b3262b6a7da245b8a74 GetElementDefaultValue() {
return new RC_3756803ceb487b3262b6a7da245b8a74();
}

public T[] ToArray<T>(Func<RC_3756803ceb487b3262b6a7da245b8a74, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_605921a60a3ac4dd1382c185e90bacac recordList, Func<RC_3756803ceb487b3262b6a7da245b8a74, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_605921a60a3ac4dd1382c185e90bacac(RC_3756803ceb487b3262b6a7da245b8a74[] array) {
  RL_605921a60a3ac4dd1382c185e90bacac result = new RL_605921a60a3ac4dd1382c185e90bacac();
result.InnerFromArray(array);
    return result;
}

public static RL_605921a60a3ac4dd1382c185e90bacac ToList<T>(T[] array, Func <T, RC_3756803ceb487b3262b6a7da245b8a74> converter) {
  RL_605921a60a3ac4dd1382c185e90bacac result = new RL_605921a60a3ac4dd1382c185e90bacac();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_605921a60a3ac4dd1382c185e90bacac FromRestList<T>(RestList<T> restList, Func <T, RC_3756803ceb487b3262b6a7da245b8a74> converter) {
  RL_605921a60a3ac4dd1382c185e90bacac result = new RL_605921a60a3ac4dd1382c185e90bacac();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_605921a60a3ac4dd1382c185e90bacac() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3756803ceb487b3262b6a7da245b8a74> NewList() {
return new RL_605921a60a3ac4dd1382c185e90bacac();
}


} // RL_605921a60a3ac4dd1382c185e90bacac
}

