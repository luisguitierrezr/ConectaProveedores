namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (mXAqw4qk60aYJkGRIGLKEg)
///  <code>RC_552c926b5ae43c594aa2b0762b255928</code> that represent
/// s <code>UserRoleConceptEntraRoleUser_Extended_InternalRecord</code> <p>Description: </p>
/// </summary>
// Name: UserRoleConceptEntraRoleUser_Extended_InternalRecord
public partial struct RC_552c926b5ae43c594aa2b0762b255928 : ITypedRecord<RC_552c926b5ae43c594aa2b0762b255928> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdRoleConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ibfwUXfv1rTUACc3+2O7uQ");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord ssENRoleConcept;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_552c926b5ae43c594aa2b0762b255928() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENRoleConcept = new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(4,false);
    all[2] = new BitArray(6,false);
    all[3] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRoleConcept.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENRoleConcept.OptimizedAttributes = value[1];
    ssENEntraRole.OptimizedAttributes = value[2];
    ssENUser_Extended_Internal.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENRoleConcept.OptimizedAttributes;
    all[2] = ssENEntraRole.OptimizedAttributes;
    all[3] = ssENUser_Extended_Internal.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENRoleConcept.Read( r, ref index);
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
public void ReadIM(RC_552c926b5ae43c594aa2b0762b255928 r) {
this = r;
}


public static bool operator == (RC_552c926b5ae43c594aa2b0762b255928 a, RC_552c926b5ae43c594aa2b0762b255928 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENRoleConcept != b.ssENRoleConcept) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_552c926b5ae43c594aa2b0762b255928 a, RC_552c926b5ae43c594aa2b0762b255928 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_552c926b5ae43c594aa2b0762b255928)) return false;
return (this == (RC_552c926b5ae43c594aa2b0762b255928)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENRoleConcept.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENRoleConcept.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENRoleConcept.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_552c926b5ae43c594aa2b0762b255928 Duplicate() {
RC_552c926b5ae43c594aa2b0762b255928 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENRoleConcept = (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord)this.ssENRoleConcept.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "roleconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleConcept")) variable.Value = ssENRoleConcept; else variable.Optimized = true;
variable.SetFieldName("roleconcept");
} else if (head == "entrarole") {
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdRoleConcept) {
return ssENRoleConcept;
}
if (key == IdEntraRole) {
return ssENEntraRole;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdRoleConcept.Key.AsGuid) {
return ssENRoleConcept;
}
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
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENRoleConcept.FillFromOther((IRecord) other.AttributeGet(IdRoleConcept));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_552c926b5ae43c594aa2b0762b255928
/// <summary>
/// RecordList type <code>UserRoleConceptEntraRoleUser_Extended_InternalRecordList</code> that
///  represents a record list of <code>User, RoleConcept, EntraRole, User_Extended_Internal</code>
/// </summary>
public partial class RL_bdfd519ca40e4329aaefd81b9f10ff89 : GenericRecordList<RC_552c926b5ae43c594aa2b0762b255928>, IEnumerable, IEnumerator {

protected override RC_552c926b5ae43c594aa2b0762b255928 GetElementDefaultValue() {
return new RC_552c926b5ae43c594aa2b0762b255928();
}

public T[] ToArray<T>(Func<RC_552c926b5ae43c594aa2b0762b255928, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bdfd519ca40e4329aaefd81b9f10ff89 recordList, Func<RC_552c926b5ae43c594aa2b0762b255928, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bdfd519ca40e4329aaefd81b9f10ff89(RC_552c926b5ae43c594aa2b0762b255928[] array) {
  RL_bdfd519ca40e4329aaefd81b9f10ff89 result = new RL_bdfd519ca40e4329aaefd81b9f10ff89();
result.InnerFromArray(array);
    return result;
}

public static RL_bdfd519ca40e4329aaefd81b9f10ff89 ToList<T>(T[] array, Func <T, RC_552c926b5ae43c594aa2b0762b255928> converter) {
  RL_bdfd519ca40e4329aaefd81b9f10ff89 result = new RL_bdfd519ca40e4329aaefd81b9f10ff89();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bdfd519ca40e4329aaefd81b9f10ff89 FromRestList<T>(RestList<T> restList, Func <T, RC_552c926b5ae43c594aa2b0762b255928> converter) {
  RL_bdfd519ca40e4329aaefd81b9f10ff89 result = new RL_bdfd519ca40e4329aaefd81b9f10ff89();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bdfd519ca40e4329aaefd81b9f10ff89() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(4,false);
def[2] = new BitArray(6,false);
def[3] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_552c926b5ae43c594aa2b0762b255928> NewList() {
return new RL_bdfd519ca40e4329aaefd81b9f10ff89();
}


} // RL_bdfd519ca40e4329aaefd81b9f10ff89
}

