namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (BtQLcXjvK0m4Ez6fpaJevg)
///  <code>RC_2ac88c51f2d9ed908454e6a06ffe188e</code> that represent
/// s <code>DropdownOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: DropdownOptionalConfigsRecord
public partial struct RC_2ac88c51f2d9ed908454e6a06ffe188e : ITypedRecord<RC_2ac88c51f2d9ed908454e6a06ffe188e> {
internal static readonly GlobalObjectKey IdDropdownOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UYzIKtnykO2EVOagb_4Yjg");

public ST_4e53cb8815b86020ced1d2f2652c9b1dStructure ssSTDropdownOptionalConfigs;


public static implicit operator ST_4e53cb8815b86020ced1d2f2652c9b1dStructure( RC_2ac88c51f2d9ed908454e6a06ffe188e r) {
return r.ssSTDropdownOptionalConfigs;
}

public static implicit operator RC_2ac88c51f2d9ed908454e6a06ffe188e (ST_4e53cb8815b86020ced1d2f2652c9b1dStructure r) {
RC_2ac88c51f2d9ed908454e6a06ffe188e res = new RC_2ac88c51f2d9ed908454e6a06ffe188e ();
res.ssSTDropdownOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2ac88c51f2d9ed908454e6a06ffe188e() {
OptimizedAttributes = null;
ssSTDropdownOptionalConfigs = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
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
    ssSTDropdownOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTDropdownOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_2ac88c51f2d9ed908454e6a06ffe188e r) {
this = r;
}


public static bool operator == (RC_2ac88c51f2d9ed908454e6a06ffe188e a, RC_2ac88c51f2d9ed908454e6a06ffe188e b) {
if (a.ssSTDropdownOptionalConfigs != b.ssSTDropdownOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_2ac88c51f2d9ed908454e6a06ffe188e a, RC_2ac88c51f2d9ed908454e6a06ffe188e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2ac88c51f2d9ed908454e6a06ffe188e)) return false;
return (this == (RC_2ac88c51f2d9ed908454e6a06ffe188e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDropdownOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDropdownOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDropdownOptionalConfigs.InternalRecursiveSave();
}


public RC_2ac88c51f2d9ed908454e6a06ffe188e Duplicate() {
RC_2ac88c51f2d9ed908454e6a06ffe188e t;
t.ssSTDropdownOptionalConfigs = (ST_4e53cb8815b86020ced1d2f2652c9b1dStructure)this.ssSTDropdownOptionalConfigs.Duplicate();
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
if (head == "dropdownoptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DropdownOptionalConfigs")) variable.Value = ssSTDropdownOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("dropdownoptionalconfigs");
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
if (key == IdDropdownOptionalConfigs) {
return ssSTDropdownOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDropdownOptionalConfigs.Key.AsGuid) {
return ssSTDropdownOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDropdownOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdDropdownOptionalConfigs));
}
} // RC_2ac88c51f2d9ed908454e6a06ffe188e
/// <summary>
/// RecordList type <code>DropdownOptionalConfigsRecordList</code> that represents a record list of
///  <code>DropdownOptionalConfigs</code>
/// </summary>
public partial class RL_4645896d20bae069726fdb473c154d2d : GenericRecordList<RC_2ac88c51f2d9ed908454e6a06ffe188e>, IEnumerable, IEnumerator {

protected override RC_2ac88c51f2d9ed908454e6a06ffe188e GetElementDefaultValue() {
return new RC_2ac88c51f2d9ed908454e6a06ffe188e();
}

public T[] ToArray<T>(Func<RC_2ac88c51f2d9ed908454e6a06ffe188e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4645896d20bae069726fdb473c154d2d recordList, Func<RC_2ac88c51f2d9ed908454e6a06ffe188e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4645896d20bae069726fdb473c154d2d(RC_2ac88c51f2d9ed908454e6a06ffe188e[] array) {
  RL_4645896d20bae069726fdb473c154d2d result = new RL_4645896d20bae069726fdb473c154d2d();
result.InnerFromArray(array);
    return result;
}

public static RL_4645896d20bae069726fdb473c154d2d ToList<T>(T[] array, Func <T, RC_2ac88c51f2d9ed908454e6a06ffe188e> converter) {
  RL_4645896d20bae069726fdb473c154d2d result = new RL_4645896d20bae069726fdb473c154d2d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4645896d20bae069726fdb473c154d2d FromRestList<T>(RestList<T> restList, Func <T, RC_2ac88c51f2d9ed908454e6a06ffe188e> converter) {
  RL_4645896d20bae069726fdb473c154d2d result = new RL_4645896d20bae069726fdb473c154d2d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4645896d20bae069726fdb473c154d2d() : base() {
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
protected override OSList<RC_2ac88c51f2d9ed908454e6a06ffe188e> NewList() {
return new RL_4645896d20bae069726fdb473c154d2d();
}


} // RL_4645896d20bae069726fdb473c154d2d
}

