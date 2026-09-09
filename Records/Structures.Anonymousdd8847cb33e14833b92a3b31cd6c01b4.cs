namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (y0eI3eEzM0i5KjsxzWwBtA)
///  <code>RC_715f3e88ae56d2a37280e6d709b67948</code> that represents <code>ItemEM_RMRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ItemEM_RMRecord
public partial struct RC_715f3e88ae56d2a37280e6d709b67948 : ITypedRecord<RC_715f3e88ae56d2a37280e6d709b67948> {
internal static readonly GlobalObjectKey IdItemEM_RM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*iD5fcVauo9JygObXCbZ5SA");

public ST_121fe028e1d357d74e80a524b7b1ba16Structure ssSTItemEM_RM;


public static implicit operator ST_121fe028e1d357d74e80a524b7b1ba16Structure( RC_715f3e88ae56d2a37280e6d709b67948 r) {
return r.ssSTItemEM_RM;
}

public static implicit operator RC_715f3e88ae56d2a37280e6d709b67948 (ST_121fe028e1d357d74e80a524b7b1ba16Structure r) {
RC_715f3e88ae56d2a37280e6d709b67948 res = new RC_715f3e88ae56d2a37280e6d709b67948 ();
res.ssSTItemEM_RM = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_715f3e88ae56d2a37280e6d709b67948() {
OptimizedAttributes = null;
ssSTItemEM_RM = new ST_121fe028e1d357d74e80a524b7b1ba16Structure();
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
    ssSTItemEM_RM.OptimizedAttributes = value[0];
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
ssSTItemEM_RM.Read( r, ref index);
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
public void ReadIM(RC_715f3e88ae56d2a37280e6d709b67948 r) {
this = r;
}


public static bool operator == (RC_715f3e88ae56d2a37280e6d709b67948 a, RC_715f3e88ae56d2a37280e6d709b67948 b) {
if (a.ssSTItemEM_RM != b.ssSTItemEM_RM) return false;
return true;
}

public static bool operator != (RC_715f3e88ae56d2a37280e6d709b67948 a, RC_715f3e88ae56d2a37280e6d709b67948 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_715f3e88ae56d2a37280e6d709b67948)) return false;
return (this == (RC_715f3e88ae56d2a37280e6d709b67948)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTItemEM_RM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTItemEM_RM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTItemEM_RM.InternalRecursiveSave();
}


public RC_715f3e88ae56d2a37280e6d709b67948 Duplicate() {
RC_715f3e88ae56d2a37280e6d709b67948 t;
t.ssSTItemEM_RM = (ST_121fe028e1d357d74e80a524b7b1ba16Structure)this.ssSTItemEM_RM.Duplicate();
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
if (head == "itemem_rm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemEM_RM")) variable.Value = ssSTItemEM_RM; else variable.Optimized = true;
variable.SetFieldName("itemem_rm");
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
if (key == IdItemEM_RM) {
return ssSTItemEM_RM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdItemEM_RM.Key.AsGuid) {
return ssSTItemEM_RM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTItemEM_RM.FillFromOther((IRecord) other.AttributeGet(IdItemEM_RM));
}
} // RC_715f3e88ae56d2a37280e6d709b67948
/// <summary>
/// RecordList type <code>ItemEM_RMRecordList</code> that represents a record list of
///  <code>ItemEM_RM</code>
/// </summary>
public partial class RL_a5dc03e51f5d199d1f1ad170352bf4e2 : GenericRecordList<RC_715f3e88ae56d2a37280e6d709b67948>, IEnumerable, IEnumerator {

protected override RC_715f3e88ae56d2a37280e6d709b67948 GetElementDefaultValue() {
return new RC_715f3e88ae56d2a37280e6d709b67948();
}

public T[] ToArray<T>(Func<RC_715f3e88ae56d2a37280e6d709b67948, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a5dc03e51f5d199d1f1ad170352bf4e2 recordList, Func<RC_715f3e88ae56d2a37280e6d709b67948, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a5dc03e51f5d199d1f1ad170352bf4e2(RC_715f3e88ae56d2a37280e6d709b67948[] array) {
  RL_a5dc03e51f5d199d1f1ad170352bf4e2 result = new RL_a5dc03e51f5d199d1f1ad170352bf4e2();
result.InnerFromArray(array);
    return result;
}

public static RL_a5dc03e51f5d199d1f1ad170352bf4e2 ToList<T>(T[] array, Func <T, RC_715f3e88ae56d2a37280e6d709b67948> converter) {
  RL_a5dc03e51f5d199d1f1ad170352bf4e2 result = new RL_a5dc03e51f5d199d1f1ad170352bf4e2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a5dc03e51f5d199d1f1ad170352bf4e2 FromRestList<T>(RestList<T> restList, Func <T, RC_715f3e88ae56d2a37280e6d709b67948> converter) {
  RL_a5dc03e51f5d199d1f1ad170352bf4e2 result = new RL_a5dc03e51f5d199d1f1ad170352bf4e2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a5dc03e51f5d199d1f1ad170352bf4e2() : base() {
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
protected override OSList<RC_715f3e88ae56d2a37280e6d709b67948> NewList() {
return new RL_a5dc03e51f5d199d1f1ad170352bf4e2();
}


} // RL_a5dc03e51f5d199d1f1ad170352bf4e2
}

