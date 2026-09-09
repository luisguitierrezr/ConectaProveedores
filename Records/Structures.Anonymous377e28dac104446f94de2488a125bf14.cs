namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2ih+NwTBb0SU3iSIoSW_FA)
///  <code>RC_2d026dc77741fad17a11f0df63aa3b4b</code> that represent
/// s <code>EntraRoleUser_Extended_InternalRecord</code> <p>Description: </p>
/// </summary>
// Name: EntraRoleUser_Extended_InternalRecord
public partial struct RC_2d026dc77741fad17a11f0df63aa3b4b : ITypedRecord<RC_2d026dc77741fad17a11f0df63aa3b4b> {
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_2d026dc77741fad17a11f0df63aa3b4b() {
OptimizedAttributes = null;
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENEntraRole.OptimizedAttributes = value[0];
    ssENUser_Extended_Internal.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENEntraRole.OptimizedAttributes;
    all[1] = ssENUser_Extended_Internal.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENEntraRole.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
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
public void ReadIM(RC_2d026dc77741fad17a11f0df63aa3b4b r) {
this = r;
}


public static bool operator == (RC_2d026dc77741fad17a11f0df63aa3b4b a, RC_2d026dc77741fad17a11f0df63aa3b4b b) {
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_2d026dc77741fad17a11f0df63aa3b4b a, RC_2d026dc77741fad17a11f0df63aa3b4b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2d026dc77741fad17a11f0df63aa3b4b)) return false;
return (this == (RC_2d026dc77741fad17a11f0df63aa3b4b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENEntraRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENEntraRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_2d026dc77741fad17a11f0df63aa3b4b Duplicate() {
RC_2d026dc77741fad17a11f0df63aa3b4b t;
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
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
if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
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
if (key == IdEntraRole) {
return ssENEntraRole;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_2d026dc77741fad17a11f0df63aa3b4b
/// <summary>
/// RecordList type <code>EntraRoleUser_Extended_InternalRecordList</code> that represents a record
///  list of <code>EntraRole, User_Extended_Internal</code>
/// </summary>
public partial class RL_ea7d18baeeefa57d5c86706d7efb98e9 : GenericRecordList<RC_2d026dc77741fad17a11f0df63aa3b4b>, IEnumerable, IEnumerator {

protected override RC_2d026dc77741fad17a11f0df63aa3b4b GetElementDefaultValue() {
return new RC_2d026dc77741fad17a11f0df63aa3b4b();
}

public T[] ToArray<T>(Func<RC_2d026dc77741fad17a11f0df63aa3b4b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ea7d18baeeefa57d5c86706d7efb98e9 recordList, Func<RC_2d026dc77741fad17a11f0df63aa3b4b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ea7d18baeeefa57d5c86706d7efb98e9(RC_2d026dc77741fad17a11f0df63aa3b4b[] array) {
  RL_ea7d18baeeefa57d5c86706d7efb98e9 result = new RL_ea7d18baeeefa57d5c86706d7efb98e9();
result.InnerFromArray(array);
    return result;
}

public static RL_ea7d18baeeefa57d5c86706d7efb98e9 ToList<T>(T[] array, Func <T, RC_2d026dc77741fad17a11f0df63aa3b4b> converter) {
  RL_ea7d18baeeefa57d5c86706d7efb98e9 result = new RL_ea7d18baeeefa57d5c86706d7efb98e9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ea7d18baeeefa57d5c86706d7efb98e9 FromRestList<T>(RestList<T> restList, Func <T, RC_2d026dc77741fad17a11f0df63aa3b4b> converter) {
  RL_ea7d18baeeefa57d5c86706d7efb98e9 result = new RL_ea7d18baeeefa57d5c86706d7efb98e9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ea7d18baeeefa57d5c86706d7efb98e9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(6,false);
def[1] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2d026dc77741fad17a11f0df63aa3b4b> NewList() {
return new RL_ea7d18baeeefa57d5c86706d7efb98e9();
}


} // RL_ea7d18baeeefa57d5c86706d7efb98e9
}

