namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (MyJfnm8bsk2fXdT2M2t6_A)
///  <code>RC_4eba0035378aebca97affd4e1528379d</code> that represent
/// s <code>AppRolesListTextTelcelDirectionsListTextIsCorporativoCxPCorporativoRegionIdRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: AppRolesListTextTelcelDirectionsListTextIsCorporativoCxPCorporativoRegionIdRecord
public partial struct RC_4eba0035378aebca97affd4e1528379d : ITypedRecord<RC_4eba0035378aebca97affd4e1528379d> {
internal static readonly GlobalObjectKey IdAppRolesListText = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S_3NIW98TWc+6Ivt92COCg");
internal static readonly GlobalObjectKey IdTelcelDirectionsListText = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9fRUL_jvuu6AJftw3RRz7g");
internal static readonly GlobalObjectKey IdIsCorporativoCxP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*41NazsmnBer5RZhKgM_ubw");
internal static readonly GlobalObjectKey IdCorporativoRegionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pqEP32KMmpQuFVU2HFSJIw");

public string ssAppRolesListText;

public string ssTelcelDirectionsListText;

public bool ssIsCorporativoCxP;

public long ssCorporativoRegionId;


public BitArray OptimizedAttributes;

public RC_4eba0035378aebca97affd4e1528379d() {
OptimizedAttributes = null;
ssAppRolesListText = "";
ssTelcelDirectionsListText = "";
ssIsCorporativoCxP = false;
ssCorporativoRegionId = 0L;
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
ssAppRolesListText = r.ReadText(index++, "AppRolesListTextTelcelDirectionsListTextIsCorporativoCxPCorporativoRegionIdRecord.AppRolesListText", "");
ssTelcelDirectionsListText = r.ReadText(index++, "AppRolesListTextTelcelDirectionsListTextIsCorporativoCxPCorporativoRegionIdRecord.TelcelDirectionsListText", "");
ssIsCorporativoCxP = r.ReadBoolean(index++, "AppRolesListTextTelcelDirectionsListTextIsCorporativoCxPCorporativoRegionIdRecord.IsCorporativoCxP", false);
ssCorporativoRegionId = r.ReadEntityReferenceLongInteger(index++, "AppRolesListTextTelcelDirectionsListTextIsCorporativoCxPCorporativoRegionIdRecord.CorporativoRegionId", 0L);
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
public void ReadIM(RC_4eba0035378aebca97affd4e1528379d r) {
this = r;
}


public static bool operator == (RC_4eba0035378aebca97affd4e1528379d a, RC_4eba0035378aebca97affd4e1528379d b) {
if (a.ssAppRolesListText != b.ssAppRolesListText) return false;
if (a.ssTelcelDirectionsListText != b.ssTelcelDirectionsListText) return false;
if (a.ssIsCorporativoCxP != b.ssIsCorporativoCxP) return false;
if (a.ssCorporativoRegionId != b.ssCorporativoRegionId) return false;
return true;
}

public static bool operator != (RC_4eba0035378aebca97affd4e1528379d a, RC_4eba0035378aebca97affd4e1528379d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4eba0035378aebca97affd4e1528379d)) return false;
return (this == (RC_4eba0035378aebca97affd4e1528379d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAppRolesListText.GetHashCode()
 ^ ssTelcelDirectionsListText.GetHashCode()
 ^ ssIsCorporativoCxP.GetHashCode()
 ^ ssCorporativoRegionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_4eba0035378aebca97affd4e1528379d Duplicate() {
RC_4eba0035378aebca97affd4e1528379d t;
t.ssAppRolesListText = this.ssAppRolesListText;
t.ssTelcelDirectionsListText = this.ssTelcelDirectionsListText;
t.ssIsCorporativoCxP = this.ssIsCorporativoCxP;
t.ssCorporativoRegionId = this.ssCorporativoRegionId;
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
if (head == "approleslisttext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AppRolesListText")) variable.Value = ssAppRolesListText; else variable.Optimized = true;
} else if (head == "telceldirectionslisttext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirectionsListText")) variable.Value = ssTelcelDirectionsListText; else variable.Optimized = true;
} else if (head == "iscorporativocxp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsCorporativoCxP")) variable.Value = ssIsCorporativoCxP; else variable.Optimized = true;
} else if (head == "corporativoregionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CorporativoRegionId")) variable.Value = ssCorporativoRegionId; else variable.Optimized = true;
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
if (key == IdAppRolesListText) {
return ssAppRolesListText;
}
if (key == IdTelcelDirectionsListText) {
return ssTelcelDirectionsListText;
}
if (key == IdIsCorporativoCxP) {
return ssIsCorporativoCxP;
}
if (key == IdCorporativoRegionId) {
return ssCorporativoRegionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAppRolesListText.Key.AsGuid) {
return ssAppRolesListText;
}
if (attributeKey == IdTelcelDirectionsListText.Key.AsGuid) {
return ssTelcelDirectionsListText;
}
if (attributeKey == IdIsCorporativoCxP.Key.AsGuid) {
return ssIsCorporativoCxP;
}
if (attributeKey == IdCorporativoRegionId.Key.AsGuid) {
return ssCorporativoRegionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssAppRolesListText = (string) other.AttributeGet(IdAppRolesListText);
ssTelcelDirectionsListText = (string) other.AttributeGet(IdTelcelDirectionsListText);
ssIsCorporativoCxP = (bool) other.AttributeGet(IdIsCorporativoCxP);
ssCorporativoRegionId = (long) other.AttributeGet(IdCorporativoRegionId);
}
} // RC_4eba0035378aebca97affd4e1528379d
/// <summary>
/// RecordList type
///  <code>AppRolesListTextTelcelDirectionsListTextIsCorporativoCxPCorporativoRegionIdRecordList</code
/// > that represents a record list of <code>Text, Text, Boolean, RegionIdentifier</code>
/// </summary>
public partial class RL_3524a45d53426bfc17d7a116e5e7b799 : GenericRecordList<RC_4eba0035378aebca97affd4e1528379d>, IEnumerable, IEnumerator {

protected override RC_4eba0035378aebca97affd4e1528379d GetElementDefaultValue() {
return new RC_4eba0035378aebca97affd4e1528379d();
}

public T[] ToArray<T>(Func<RC_4eba0035378aebca97affd4e1528379d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3524a45d53426bfc17d7a116e5e7b799 recordList, Func<RC_4eba0035378aebca97affd4e1528379d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3524a45d53426bfc17d7a116e5e7b799(RC_4eba0035378aebca97affd4e1528379d[] array) {
  RL_3524a45d53426bfc17d7a116e5e7b799 result = new RL_3524a45d53426bfc17d7a116e5e7b799();
result.InnerFromArray(array);
    return result;
}

public static RL_3524a45d53426bfc17d7a116e5e7b799 ToList<T>(T[] array, Func <T, RC_4eba0035378aebca97affd4e1528379d> converter) {
  RL_3524a45d53426bfc17d7a116e5e7b799 result = new RL_3524a45d53426bfc17d7a116e5e7b799();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3524a45d53426bfc17d7a116e5e7b799 FromRestList<T>(RestList<T> restList, Func <T, RC_4eba0035378aebca97affd4e1528379d> converter) {
  RL_3524a45d53426bfc17d7a116e5e7b799 result = new RL_3524a45d53426bfc17d7a116e5e7b799();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3524a45d53426bfc17d7a116e5e7b799() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_4eba0035378aebca97affd4e1528379d> NewList() {
return new RL_3524a45d53426bfc17d7a116e5e7b799();
}


} // RL_3524a45d53426bfc17d7a116e5e7b799
}

