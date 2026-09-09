using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] SideMenuBehavior (Q9qIHeq4AE+allibPPhfiw)
///  <code>EN_c1e622743b79c1510fd62a0adf89686bEntityRecord</code> that represent
/// s <code>SideMenuBehavior</code> <p>Description: Sets the side menu animation behavior.</p>
/// </summary>
// Name: SideMenuBehavior
public partial struct EN_c1e622743b79c1510fd62a0adf89686bEntityRecord : ITypedRecord<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord> {
internal static readonly GlobalObjectKey IdSideMenuBehavior = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*DdoQ3SyAXkaYSk0JZCz+hQ");

private string _ssSideMenuBehavior;
public string ssSideMenuBehavior{
  get{
      return _ssSideMenuBehavior;
  }
  set{
      if((_ssSideMenuBehavior!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssSideMenuBehavior = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_c1e622743b79c1510fd62a0adf89686bEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssSideMenuBehavior = "";
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
ssSideMenuBehavior = r.ReadText(index++, "SideMenuBehavior.SideMenuBehavior", "");
ChangedAttributes = new BitArray(1,false);
OptimizedAttributes = new BitArray(1,false);
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
public void ReadIM(EN_c1e622743b79c1510fd62a0adf89686bEntityRecord r) {
this = r;
}


public static bool operator == (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord a, EN_c1e622743b79c1510fd62a0adf89686bEntityRecord b) {
if (a.ssSideMenuBehavior != b.ssSideMenuBehavior) return false;
return true;
}

public static bool operator != (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord a, EN_c1e622743b79c1510fd62a0adf89686bEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord)) return false;
return (this == (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSideMenuBehavior.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_c1e622743b79c1510fd62a0adf89686bEntityRecord Duplicate() {
EN_c1e622743b79c1510fd62a0adf89686bEntityRecord t;
t._ssSideMenuBehavior = this._ssSideMenuBehavior;
t.ChangedAttributes = new BitArray(1);
t.OptimizedAttributes = new BitArray(1);
for(int i = 0; i < 1; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (head == "sidemenubehavior") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SideMenuBehavior")) variable.Value = ssSideMenuBehavior; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSideMenuBehavior)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSideMenuBehavior)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSideMenuBehavior) {
return ssSideMenuBehavior;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSideMenuBehavior.Key.AsGuid) {
return ssSideMenuBehavior;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssSideMenuBehavior = (string) other.AttributeGet(IdSideMenuBehavior);
ChangedAttributes[0] = other.ChangedAttributeGet(IdSideMenuBehavior);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdSideMenuBehavior);
}
} // EN_c1e622743b79c1510fd62a0adf89686bEntityRecord

/// <summary>
/// RecordList type <code>SideMenuBehaviorList</code> that represents a record list of
///  <code>SideMenuBehavior</code>
/// </summary>
public partial class RL_d1ec4133b9c9274ea17a14b497f44d93 : GenericRecordList<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord>, IEnumerable, IEnumerator {

protected override EN_c1e622743b79c1510fd62a0adf89686bEntityRecord GetElementDefaultValue() {
return new EN_c1e622743b79c1510fd62a0adf89686bEntityRecord();
}

public T[] ToArray<T>(Func<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d1ec4133b9c9274ea17a14b497f44d93 recordList, Func<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d1ec4133b9c9274ea17a14b497f44d93(EN_c1e622743b79c1510fd62a0adf89686bEntityRecord[] array) {
  RL_d1ec4133b9c9274ea17a14b497f44d93 result = new RL_d1ec4133b9c9274ea17a14b497f44d93();
result.InnerFromArray(array);
    return result;
}

public static RL_d1ec4133b9c9274ea17a14b497f44d93 ToList<T>(T[] array, Func <T, EN_c1e622743b79c1510fd62a0adf89686bEntityRecord> converter) {
  RL_d1ec4133b9c9274ea17a14b497f44d93 result = new RL_d1ec4133b9c9274ea17a14b497f44d93();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d1ec4133b9c9274ea17a14b497f44d93 FromRestList<T>(RestList<T> restList, Func <T, EN_c1e622743b79c1510fd62a0adf89686bEntityRecord> converter) {
  RL_d1ec4133b9c9274ea17a14b497f44d93 result = new RL_d1ec4133b9c9274ea17a14b497f44d93();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d1ec4133b9c9274ea17a14b497f44d93() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord> NewList() {
return new RL_d1ec4133b9c9274ea17a14b497f44d93();
}


} // RL_d1ec4133b9c9274ea17a14b497f44d93
}
