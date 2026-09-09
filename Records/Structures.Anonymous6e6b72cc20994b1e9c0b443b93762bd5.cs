namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (zHJrbpkgHkucC0Q7k3Yr1Q)
///  <code>RC_3680fcc88ad001f8f5724e587c7c5ba6</code> that represent
/// s <code>EntryOrderRequestUpdateRecord</code> <p>Description: </p>
/// </summary>
// Name: EntryOrderRequestUpdateRecord
public partial struct RC_3680fcc88ad001f8f5724e587c7c5ba6 : ITypedRecord<RC_3680fcc88ad001f8f5724e587c7c5ba6> {
internal static readonly GlobalObjectKey IdEntryOrderRequestUpdate = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yPyANtCK+AH1ck5YfHxbpg");

public ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure ssSTEntryOrderRequestUpdate;


public static implicit operator ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure( RC_3680fcc88ad001f8f5724e587c7c5ba6 r) {
return r.ssSTEntryOrderRequestUpdate;
}

public static implicit operator RC_3680fcc88ad001f8f5724e587c7c5ba6 (ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure r) {
RC_3680fcc88ad001f8f5724e587c7c5ba6 res = new RC_3680fcc88ad001f8f5724e587c7c5ba6 ();
res.ssSTEntryOrderRequestUpdate = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3680fcc88ad001f8f5724e587c7c5ba6() {
OptimizedAttributes = null;
ssSTEntryOrderRequestUpdate = new ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure();
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
    ssSTEntryOrderRequestUpdate.OptimizedAttributes = value[0];
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
ssSTEntryOrderRequestUpdate.Read( r, ref index);
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
public void ReadIM(RC_3680fcc88ad001f8f5724e587c7c5ba6 r) {
this = r;
}


public static bool operator == (RC_3680fcc88ad001f8f5724e587c7c5ba6 a, RC_3680fcc88ad001f8f5724e587c7c5ba6 b) {
if (a.ssSTEntryOrderRequestUpdate != b.ssSTEntryOrderRequestUpdate) return false;
return true;
}

public static bool operator != (RC_3680fcc88ad001f8f5724e587c7c5ba6 a, RC_3680fcc88ad001f8f5724e587c7c5ba6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3680fcc88ad001f8f5724e587c7c5ba6)) return false;
return (this == (RC_3680fcc88ad001f8f5724e587c7c5ba6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEntryOrderRequestUpdate.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEntryOrderRequestUpdate.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEntryOrderRequestUpdate.InternalRecursiveSave();
}


public RC_3680fcc88ad001f8f5724e587c7c5ba6 Duplicate() {
RC_3680fcc88ad001f8f5724e587c7c5ba6 t;
t.ssSTEntryOrderRequestUpdate = (ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure)this.ssSTEntryOrderRequestUpdate.Duplicate();
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
if (head == "entryorderrequestupdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryOrderRequestUpdate")) variable.Value = ssSTEntryOrderRequestUpdate; else variable.Optimized = true;
variable.SetFieldName("entryorderrequestupdate");
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
if (key == IdEntryOrderRequestUpdate) {
return ssSTEntryOrderRequestUpdate;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEntryOrderRequestUpdate.Key.AsGuid) {
return ssSTEntryOrderRequestUpdate;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEntryOrderRequestUpdate.FillFromOther((IRecord) other.AttributeGet(IdEntryOrderRequestUpdate));
}
} // RC_3680fcc88ad001f8f5724e587c7c5ba6
/// <summary>
/// RecordList type <code>EntryOrderRequestUpdateRecordList</code> that represents a record list of
///  <code>EntryOrderRequestUpdate</code>
/// </summary>
public partial class RL_14da72423a255164aadd46b9b7223281 : GenericRecordList<RC_3680fcc88ad001f8f5724e587c7c5ba6>, IEnumerable, IEnumerator {

protected override RC_3680fcc88ad001f8f5724e587c7c5ba6 GetElementDefaultValue() {
return new RC_3680fcc88ad001f8f5724e587c7c5ba6();
}

public T[] ToArray<T>(Func<RC_3680fcc88ad001f8f5724e587c7c5ba6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_14da72423a255164aadd46b9b7223281 recordList, Func<RC_3680fcc88ad001f8f5724e587c7c5ba6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_14da72423a255164aadd46b9b7223281(RC_3680fcc88ad001f8f5724e587c7c5ba6[] array) {
  RL_14da72423a255164aadd46b9b7223281 result = new RL_14da72423a255164aadd46b9b7223281();
result.InnerFromArray(array);
    return result;
}

public static RL_14da72423a255164aadd46b9b7223281 ToList<T>(T[] array, Func <T, RC_3680fcc88ad001f8f5724e587c7c5ba6> converter) {
  RL_14da72423a255164aadd46b9b7223281 result = new RL_14da72423a255164aadd46b9b7223281();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_14da72423a255164aadd46b9b7223281 FromRestList<T>(RestList<T> restList, Func <T, RC_3680fcc88ad001f8f5724e587c7c5ba6> converter) {
  RL_14da72423a255164aadd46b9b7223281 result = new RL_14da72423a255164aadd46b9b7223281();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_14da72423a255164aadd46b9b7223281() : base() {
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
protected override OSList<RC_3680fcc88ad001f8f5724e587c7c5ba6> NewList() {
return new RL_14da72423a255164aadd46b9b7223281();
}


} // RL_14da72423a255164aadd46b9b7223281
}

