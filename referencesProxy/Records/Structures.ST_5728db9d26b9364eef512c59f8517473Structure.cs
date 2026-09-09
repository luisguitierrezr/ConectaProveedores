namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ApplicationRole2 (uPbEY9XRZ0KVw82JgfUvQw)
///  <code>ST_5728db9d26b9364eef512c59f8517473Structure</code> that represent
/// s <code>ApplicationRole2</code> <p>Description: Structure used to store the Roles information</p>
/// </summary>
// Name: ApplicationRole2
public partial struct ST_5728db9d26b9364eef512c59f8517473Structure : ITypedRecord<ST_5728db9d26b9364eef512c59f8517473Structure> {
internal static readonly GlobalObjectKey IdKey = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*iAeSSznoIU+OKAGa1P1zMg");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*gQZNpn1n3k2CjdskAQJnFQ");
internal static readonly GlobalObjectKey IdStageKey = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*pIAlZE2bTEiFPtIeytrHtg");
internal static readonly GlobalObjectKey IdAssetKey = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*2DRz_sNCvUK1onE46I3P7g");
internal static readonly GlobalObjectKey IdExternalKey = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*QQ1_SFromUWRtu9dsqZgmw");
internal static readonly GlobalObjectKey IdClaim = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*l2vqEGpjsUymfBYTgQ7J5Q");

public string ssKey;

public string ssName;

public string ssStageKey;

public string ssAssetKey;

public string ssExternalKey;

public string ssClaim;


public BitArray OptimizedAttributes;

public ST_5728db9d26b9364eef512c59f8517473Structure() {
OptimizedAttributes = null;
ssKey = "";
ssName = "";
ssStageKey = "";
ssAssetKey = "";
ssExternalKey = "";
ssClaim = "";
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
ssKey = r.ReadText(index++, "ApplicationRole2.Key", "");
ssName = r.ReadText(index++, "ApplicationRole2.Name", "");
ssStageKey = r.ReadText(index++, "ApplicationRole2.StageKey", "");
ssAssetKey = r.ReadText(index++, "ApplicationRole2.AssetKey", "");
ssExternalKey = r.ReadText(index++, "ApplicationRole2.ExternalKey", "");
ssClaim = r.ReadText(index++, "ApplicationRole2.Claim", "");
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
public void ReadIM(ST_5728db9d26b9364eef512c59f8517473Structure r) {
this = r;
}


public static bool operator == (ST_5728db9d26b9364eef512c59f8517473Structure a, ST_5728db9d26b9364eef512c59f8517473Structure b) {
if (a.ssKey != b.ssKey) return false;
if (a.ssName != b.ssName) return false;
if (a.ssStageKey != b.ssStageKey) return false;
if (a.ssAssetKey != b.ssAssetKey) return false;
if (a.ssExternalKey != b.ssExternalKey) return false;
if (a.ssClaim != b.ssClaim) return false;
return true;
}

public static bool operator != (ST_5728db9d26b9364eef512c59f8517473Structure a, ST_5728db9d26b9364eef512c59f8517473Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5728db9d26b9364eef512c59f8517473Structure)) return false;
return (this == (ST_5728db9d26b9364eef512c59f8517473Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssKey.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssStageKey.GetHashCode()
 ^ ssAssetKey.GetHashCode()
 ^ ssExternalKey.GetHashCode()
 ^ ssClaim.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_5728db9d26b9364eef512c59f8517473Structure Duplicate() {
ST_5728db9d26b9364eef512c59f8517473Structure t;
t.ssKey = this.ssKey;
t.ssName = this.ssName;
t.ssStageKey = this.ssStageKey;
t.ssAssetKey = this.ssAssetKey;
t.ssExternalKey = this.ssExternalKey;
t.ssClaim = this.ssClaim;
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
if (head == "key") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Key")) variable.Value = ssKey; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "stagekey") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StageKey")) variable.Value = ssStageKey; else variable.Optimized = true;
} else if (head == "assetkey") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssetKey")) variable.Value = ssAssetKey; else variable.Optimized = true;
} else if (head == "externalkey") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExternalKey")) variable.Value = ssExternalKey; else variable.Optimized = true;
} else if (head == "claim") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Claim")) variable.Value = ssClaim; else variable.Optimized = true;
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
if (key == IdKey) {
return ssKey;
}
if (key == IdName) {
return ssName;
}
if (key == IdStageKey) {
return ssStageKey;
}
if (key == IdAssetKey) {
return ssAssetKey;
}
if (key == IdExternalKey) {
return ssExternalKey;
}
if (key == IdClaim) {
return ssClaim;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdKey.Key.AsGuid) {
return ssKey;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdStageKey.Key.AsGuid) {
return ssStageKey;
}
if (attributeKey == IdAssetKey.Key.AsGuid) {
return ssAssetKey;
}
if (attributeKey == IdExternalKey.Key.AsGuid) {
return ssExternalKey;
}
if (attributeKey == IdClaim.Key.AsGuid) {
return ssClaim;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssKey = (string) other.AttributeGet(IdKey);
ssName = (string) other.AttributeGet(IdName);
ssStageKey = (string) other.AttributeGet(IdStageKey);
ssAssetKey = (string) other.AttributeGet(IdAssetKey);
ssExternalKey = (string) other.AttributeGet(IdExternalKey);
ssClaim = (string) other.AttributeGet(IdClaim);
}
} // ST_5728db9d26b9364eef512c59f8517473Structure
/// <summary>
/// RecordList type <code>ApplicationRole2List</code> that represents a record list of
///  <code>ApplicationRole2</code>
/// </summary>
public partial class RL_c31de23e3d152f2b2321aea18f795545 : GenericRecordList<ST_5728db9d26b9364eef512c59f8517473Structure>, IEnumerable, IEnumerator {

protected override ST_5728db9d26b9364eef512c59f8517473Structure GetElementDefaultValue() {
return new ST_5728db9d26b9364eef512c59f8517473Structure();
}

public T[] ToArray<T>(Func<ST_5728db9d26b9364eef512c59f8517473Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c31de23e3d152f2b2321aea18f795545 recordList, Func<ST_5728db9d26b9364eef512c59f8517473Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c31de23e3d152f2b2321aea18f795545(ST_5728db9d26b9364eef512c59f8517473Structure[] array) {
  RL_c31de23e3d152f2b2321aea18f795545 result = new RL_c31de23e3d152f2b2321aea18f795545();
result.InnerFromArray(array);
    return result;
}

public static RL_c31de23e3d152f2b2321aea18f795545 ToList<T>(T[] array, Func <T, ST_5728db9d26b9364eef512c59f8517473Structure> converter) {
  RL_c31de23e3d152f2b2321aea18f795545 result = new RL_c31de23e3d152f2b2321aea18f795545();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c31de23e3d152f2b2321aea18f795545 FromRestList<T>(RestList<T> restList, Func <T, ST_5728db9d26b9364eef512c59f8517473Structure> converter) {
  RL_c31de23e3d152f2b2321aea18f795545 result = new RL_c31de23e3d152f2b2321aea18f795545();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c31de23e3d152f2b2321aea18f795545() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_5728db9d26b9364eef512c59f8517473Structure> NewList() {
return new RL_c31de23e3d152f2b2321aea18f795545();
}


} // RL_c31de23e3d152f2b2321aea18f795545
}

